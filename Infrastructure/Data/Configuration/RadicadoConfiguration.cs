using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class RadicadoConfiguration : IEntityTypeConfiguration<Radicado>
{
    public void Configure(EntityTypeBuilder<Radicado> builder)
    {
        builder.ToTable("radicados");

        builder.HasKey(r => r.Id);
        builder.Property(r => r.Id);
    }
}
