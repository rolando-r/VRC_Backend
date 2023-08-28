using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ServicioConfiguration : IEntityTypeConfiguration<Servicio>
{
    public void Configure(EntityTypeBuilder<Servicio> builder)
    {
        builder.ToTable("Servicios");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombreServicio)
        .IsRequired()
        .HasMaxLength(150);

        builder.HasOne(p => p.TipoServicio)
        .WithMany(e => e.Servicios)
        .HasForeignKey(i => i.IdTipoServicio);
    }
}