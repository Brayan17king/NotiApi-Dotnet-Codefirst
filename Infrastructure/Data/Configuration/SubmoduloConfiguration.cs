using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class SubmoduloConfiguration : IEntityTypeConfiguration<Submodulo>
{
    public void Configure(EntityTypeBuilder<Submodulo> builder)
    {
        builder.ToTable("submodulos");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreSubmodulo).IsRequired().HasMaxLength(50);
    }
}
