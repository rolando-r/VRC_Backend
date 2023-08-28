using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class SucursalConfiguration : IEntityTypeConfiguration<Sucursal>
{
    public void Configure(EntityTypeBuilder<Sucursal> builder)
    {
        builder.ToTable("Sucursales");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();

        builder.Property(p => p.NombreSucursal)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Direccion)
        .IsRequired()
        .HasMaxLength(100);
        
        builder.HasOne(p => p.ContactoPersona)
        .WithMany(e => e.Sucursales)
        .HasForeignKey(i => i.IdContactoPersona);

        builder.HasOne(p => p.Ciudad)
        .WithMany(e => e.Sucursales)
        .HasForeignKey(i => i.IdCiudad);

        builder.HasOne(p => p.Empresa)
        .WithMany(e => e.Sucursales)
        .HasForeignKey(i => i.IdEmpresa);
    }
}