using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class MaestrovsSubmoduloConfiguration : IEntityTypeConfiguration<MaestrovsSubmodulo>
{
    public void Configure(EntityTypeBuilder<MaestrovsSubmodulo> builder)
    {
        builder.ToTable("maestrosvssubmodulos");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.FechaCreacion).HasColumnType("date");

        builder.Property(x => x.FechaModificacion).HasColumnType("date");

        builder.Property(x => x.IdModuloMaestro).HasColumnType("int");
        builder.HasOne(x => x.ModuloMaestros).WithMany(x => x.MaestrovsSubmodulos).HasForeignKey(x => x.IdModuloMaestro);
        
        builder.Property(x => x.IdSubmodulo).HasColumnType("int");
        builder.HasOne(x => x.Submodulos).WithMany(x => x.MaestrovsSubmodulos).HasForeignKey(x => x.IdSubmodulo);
    }
}
