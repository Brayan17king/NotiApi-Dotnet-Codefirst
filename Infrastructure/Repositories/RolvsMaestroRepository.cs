using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class RolvsMaestroRepository : GenericRepository<RolvsMaestro>, IRolvsMaestro
{
    private readonly NotiAppContext _context;

    public RolvsMaestroRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<RolvsMaestro>> GetAllAsync()
    {
        return await _context.RolvsMaestros
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<RolvsMaestro> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.RolvsMaestros as IQueryable<RolvsMaestro>;
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
