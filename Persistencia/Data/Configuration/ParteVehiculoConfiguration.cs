using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ParteVehiculoConfiguration : IEntityTypeConfiguration<ParteVehiculo>
{
    public void Configure(EntityTypeBuilder<ParteVehiculo> builder)
    {
        builder.ToTable("ParteVehiculos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombreParteVehiculo)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasOne(p => p.EstadoParte)
        .WithMany(e => e.ParteVehiculos)
        .HasForeignKey(i => i.IdEstadoParte);
    }
}