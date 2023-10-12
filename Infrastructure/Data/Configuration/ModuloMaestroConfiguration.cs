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
        builder.ToTable("modulomaestro");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreModulo).IsRequired().HasMaxLength(50);
    }
}
