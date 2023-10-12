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
        builder.ToTable("permisosgenerico");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.MyProperty).IsRequired().HasMaxLength(50);
    }
}

