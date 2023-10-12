using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ModuloMaestroRepository : GenericRepository<ModuloMaestro>, IModuloMaestro
{
    private readonly NotiAppContext _context;

    public ModuloMaestroRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<ModuloMaestro>> GetAllAsync()
    {
        return await _context.ModuloMaestros
        .Include(a => a.RolvsMaestros)
        .Include(a => a.MaestrovsSubmodulos)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<ModuloMaestro> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.ModuloMaestros as IQueryable<ModuloMaestro>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreModulo.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Include(a => a.RolvsMaestros)
            .Include(a => a.MaestrovsSubmodulos)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}

