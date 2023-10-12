using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ModuloNotificacionConfiguration : IEntityTypeConfiguration<ModuloNotificacion>
{
    public void Configure(EntityTypeBuilder<ModuloNotificacion> builder)
    {
        builder.ToTable("modulonotificacion");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x =>x.AsuntoNotificacion).IsRequired().HasMaxLength(50);
        builder.Property(x =>x.TextoNotificacion).IsRequired().HasMaxLength(50);
        
        builder.HasOne(x => x.Radicados).WithMany(x => x.ModuloNotificaciones).HasForeignKey(x => x.IdRadicados);
        builder.HasOne(x => x.Formatos).WithMany(x => x.ModuloNotificaciones).HasForeignKey(x => x.IdFormato);
        builder.HasOne(x => x.HiloRespuestaNotificaciones).WithMany(x => x.ModuloNotificaciones).HasForeignKey(x => x.IdHiloRespuestaNotificacion);
        builder.HasOne(x => x.TipoNotificaciones).WithMany(x => x.ModuloNotificaciones).HasForeignKey(x => x.IdTipoNotificacion);
        builder.HasOne(x => x.EstadoNotificaciones).WithMany(x => x.ModuloNotificaciones).HasForeignKey(x => x.IdEstadoNotificacion);
        builder.HasOne(x => x.TipoRequerimientos).WithMany(x => x.ModuloNotificaciones).HasForeignKey(x => x.IdTipoRequerimiento);
    }
}
