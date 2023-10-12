using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class TipoNotificacionRepository : GenericRepository<TipoNotificacion>, ITipoNotificacion
{
    private readonly NotiAppContext _context;

    public TipoNotificacionRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<TipoNotificacion>> GetAllAsync()
    {
        return await _context.TipoNotificaciones
        .Include(a => a.Blockchains)
        .Include(a => a.ModuloNotificaciones)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<TipoNotificacion> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.TipoNotificaciones as IQueryable<TipoNotificacion>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.NombreTipo.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Include(a => a.Blockchains)
            .Include(a => a.ModuloNotificaciones)
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}
