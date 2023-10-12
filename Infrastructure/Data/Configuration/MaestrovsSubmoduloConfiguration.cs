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
        builder.ToTable("maestrovssubmodulo");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("bigint");

        builder.HasOne(x => x.ModuloMaestros).WithMany(x => x.MaestrovsSubmodulos).HasForeignKey(x => x.IdModuloMaestro);
        builder.HasOne(x => x.Submodulos).WithMany(x => x.MaestrovsSubmodulos).HasForeignKey(x => x.IdSubmodulo);
        
    }
}
