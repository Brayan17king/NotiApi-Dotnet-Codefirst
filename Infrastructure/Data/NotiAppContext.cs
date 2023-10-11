using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class NotiAppContext : DbContext
{
    public NotiAppContext(DbContextOptions<NotiAppContext> options) : base(options)
    {
    }
    public DbSet<Auditoria> Auditorias { get; set; }
    public DbSet<Blockchain> Blockchains { get; set; }
    public DbSet<EstadoNotificacion> EstadoNotificaciones { get; set; }
    public DbSet<Formato> Formatos { get; set; }
    public DbSet<GenericovsSubmodulo> GenericovsSubmodulos { get; set; }
    public DbSet<HiloRespuestaNotificacion> HiloRespuestaNotificaciones { get; set; }
    public DbSet<MaestrovsSubmodulo> MaestrovsSubmodulos { get; set; }
    public DbSet<ModuloMaestro> ModuloMaestros { get; set; }
    public DbSet<ModuloNotificacion> ModuloNotificaciones { get; set; }
    public DbSet<PermisosGenerico> PermisosGenericos { get; set; }
    public DbSet<Radicado> Radicados { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<RolvsMaestro> RolvsMaestros { get; set; }
    public DbSet<Submodulo> Submodulos { get; set; }
    public DbSet<TipoNotificacion> TipoNotificaciones { get; set; }
    public DbSet<TipoRequerimiento> TipoRequerimientos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
