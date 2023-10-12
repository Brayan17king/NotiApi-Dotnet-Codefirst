using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class MaestrovsSubmoduloRepository : GenericRepository<MaestrovsSubmodulo>, IMaestrovsSubmodulo
{
    private readonly NotiAppContext _context;

    public MaestrovsSubmoduloRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<MaestrovsSubmodulo>> GetAllAsync()
    {
        return await _context.MaestrovsSubmodulos
        .Include(a => a.GenericovsSubmodulos)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<MaestrovsSubmodulo> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.MaestrovsSubmodulos as IQueryable<MaestrovsSubmodulo>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Id.ToString().ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Include(a => a.GenericovsSubmodulos)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}


