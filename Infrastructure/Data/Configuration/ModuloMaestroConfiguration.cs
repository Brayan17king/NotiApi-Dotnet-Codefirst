using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ModuloMaestroConfiguration : IEntityTypeConfiguration<ModuloMaestro>
{
    public void Configure(EntityTypeBuilder<ModuloMaestro> builder)
    {
        builder.ToTable("moduulomaestros");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreModulo).IsRequired().HasMaxLength(50);

        builder.Property(x => x.FechaCreacion).HasColumnType("date");

        builder.Property(x => x.FechaModificacion).HasColumnType("date");
    }
}
