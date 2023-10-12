using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoNotificacionConfiguration : IEntityTypeConfiguration<TipoNotificacion>
{
    public void Configure(EntityTypeBuilder<TipoNotificacion> builder)
    {
        builder.ToTable("tiponotificacion");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreTipo).IsRequired().HasMaxLength(50);
    }
}
