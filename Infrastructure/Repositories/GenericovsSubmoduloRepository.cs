using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class GenericovsSubmoduloRepository : GenericRepository<GenericovsSubmodulo>, IGenericovsSubmodulo
{
    private readonly NotiAppContext _context;

    public GenericovsSubmoduloRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<GenericovsSubmodulo>> GetAllAsync()
    {
        return await _context.GenericovsSubmodulos
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<GenericovsSubmodulo> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.GenericovsSubmodulos as IQueryable<GenericovsSubmodulo>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.Id.ToString().ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}

