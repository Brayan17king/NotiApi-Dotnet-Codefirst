using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

    public class FormatoConfiguration : IEntityTypeConfiguration<Formato>
    {
        public void Configure(EntityTypeBuilder<Formato> builder)
        {
            builder.ToTable("formato");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);

            
            builder.Property(x => x.NombreFormato).IsRequired().HasMaxLength(50);
        }
    }
