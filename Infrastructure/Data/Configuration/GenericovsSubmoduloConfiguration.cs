using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class GenericovsSubmoduloConfiguration : IEntityTypeConfiguration<GenericovsSubmodulo>
{
    public void Configure(EntityTypeBuilder<GenericovsSubmodulo> builder)
    {
        builder.ToTable("genericovssubmodulo");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.HasOne(x => x.Roles).WithMany(x => x.GenericovsSubmodulos).HasForeignKey(x => x.IdRol);
        builder.HasOne(x => x.PermisosGenericos).WithMany(x => x.GenericovsSubmodulos).HasForeignKey(x => x.IdPermisosGenericos);
        builder.HasOne(x => x.MaestrovsSubmodulos).WithMany(x => x.GenericovsSubmodulos).HasForeignKey(x => x.IdMaestrovsSubmodulo);

    }
}
