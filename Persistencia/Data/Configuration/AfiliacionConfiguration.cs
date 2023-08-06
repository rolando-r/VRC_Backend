using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AfiliacionConfiguration : IEntityTypeConfiguration<Afiliacion>
{
    public void Configure(EntityTypeBuilder<Afiliacion> builder)
    {
        builder.ToTable("Afiliaciones");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p=> p.NombreAfiliacion)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasOne(p => p.PrestadorServicio)
        .WithMany(e => e.Afiliaciones)
        .HasForeignKey(i => i.IdPrestadorServicio);
    }
}