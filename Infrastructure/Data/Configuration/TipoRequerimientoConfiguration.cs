using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoRequerimientoConfiguration : IEntityTypeConfiguration<TipoRequerimiento>
{
    public void Configure(EntityTypeBuilder<TipoRequerimiento> builder)
    {
        builder.ToTable("tiporequerimiento");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreRequerimiento)
          .IsRequired()
          .HasMaxLength(50);
    }
}
