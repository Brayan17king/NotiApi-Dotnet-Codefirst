using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class PermisosGenericoConfiguration : IEntityTypeConfiguration<PermisosGenerico>
{
    public void Configure(EntityTypeBuilder<PermisosGenerico> builder)
    {
        builder.ToTable("permisosgenericos");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.MyProperty).IsRequired().HasMaxLength(50);

        builder.Property(x => x.FechaCreacion).HasColumnType("date");

        builder.Property(x => x.FechaModificacion).HasColumnType("date");
    }
}

