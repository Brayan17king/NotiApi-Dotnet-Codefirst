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
        builder.Property(x => x.Id).HasColumnType("bigint");

        builder.Property(x =>x.HasGenerado).IsRequired().HasMaxLength(50);
        
        builder.HasOne(x => x.HiloRespuestaNotificaciones).WithMany(x => x.Blockchains).HasForeignKey(x => x.IdHiloRespuestaNotificacion);
        builder.HasOne(x => x.Auditorias).WithMany(x => x.Blockchains).HasForeignKey(x => x.IdAuditoria);
    }
}
