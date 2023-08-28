using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ContactoPersonaConfiguration : IEntityTypeConfiguration<ContactoPersona>
{
    public void Configure(EntityTypeBuilder<ContactoPersona> builder)
    {
        builder.ToTable("ContactoPersonas");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.Direccion)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.Email)
        .IsRequired()
        .HasMaxLength(150);

        builder.Property(p => p.NroFijo)
        .IsRequired()
        .HasColumnType("int");

        builder.Property(p => p.NroMovil)
        .IsRequired()
        .HasColumnType("int");
        
        builder.HasOne(p => p.Persona)
        .WithMany(e => e.ContactoPersonas)
        .HasForeignKey(i => i.IdPersona);
    }
}