using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class BlockchainConfiguration : IEntityTypeConfiguration<Blockchain>
{
    public void Configure(EntityTypeBuilder<Blockchain> builder)
    {
        builder.ToTable("blockchain");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.HasGenerado).IsRequired().HasMaxLength(100);

        builder.Property(x => x.FechaCreacion).HasColumnType("date");

        builder.Property(x => x.FechaModificacion).HasColumnType("date");

        builder.Property(x => x.IdTipoNotificacion).HasColumnType("int");
        builder.HasOne(x => x.TipoNotificaciones).WithMany(x => x.Blockchains).HasForeignKey(x => x.IdTipoNotificacion);
        
        builder.Property(x => x.IdHiloRespuestaNotificacion).HasColumnType("int");
        builder.HasOne(x => x.HiloRespuestaNotificaciones).WithMany(x => x.Blockchains).HasForeignKey(x => x.IdHiloRespuestaNotificacion);
        
        builder.Property(x => x.IdAuditoria).HasColumnType("int");
        builder.HasOne(x => x.Auditorias).WithMany(x => x.Blockchains).HasForeignKey(x => x.IdAuditoria);
    }
}