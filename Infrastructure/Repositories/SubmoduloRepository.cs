using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class SubmoduloRepository : GenericRepository<Submodulo>, ISubmodulo
{
    private readonly NotiAppContext _context;

    public SubmoduloRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Submodulo>> GetAllAsync()
    {
        return await _context.Submodulos
        .Include(a => a.MaestrovsSubmodulos)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<Submodulo> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.Submodulos as IQueryable<Submodulo>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreSubmodulo.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Include(a => a.MaestrovsSubmodulos)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}
