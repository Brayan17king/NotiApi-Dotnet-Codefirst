using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;
public class PermisosGenericoRepository : GenericRepository<PermisosGenerico>, IPermisosGenerico
{
    private readonly NotiAppContext _context;

    public PermisosGenericoRepository(NotiAppContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<PermisosGenerico>> GetAllAsync()
    {
        return await _context.PermisosGenericos
        .Include(a => a.GenericovsSubmodulos)
        .ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<PermisosGenerico> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.PermisosGenericos as IQueryable<PermisosGenerico>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.MyProperty.ToLower().Contains(search));
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
