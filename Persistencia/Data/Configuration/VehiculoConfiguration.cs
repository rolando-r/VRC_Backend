using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
{
    public void Configure(EntityTypeBuilder<Vehiculo> builder)
    {
        builder.ToTable("Vehiculos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.Placa)
        .IsRequired()
        .HasMaxLength(20);

        builder.HasOne(p => p.Persona)
        .WithMany(e => e.Vehiculos)
        .HasForeignKey(i => i.IdPersona);

        builder.HasOne(p => p.InspeccionParte)
        .WithMany(e => e.Vehiculos)
        .HasForeignKey(i => i.IdInspeccionParte);

        builder.HasOne(p => p.TipoVehiculo)
        .WithMany(e => e.Vehiculos)
        .HasForeignKey(i => i.IdTipoVehiculo);

        builder.HasOne(p => p.Modelo)
        .WithMany(e => e.Vehiculos)
        .HasForeignKey(i => i.IdModelo);
    }
}