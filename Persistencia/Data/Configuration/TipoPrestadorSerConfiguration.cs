using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class TipoPrestadorSerConfiguration : IEntityTypeConfiguration<TipoPrestadorSer>
{
    public void Configure(EntityTypeBuilder<TipoPrestadorSer> builder)
    {
        builder.ToTable("TipoPrestadorSers");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
        builder.Property(p => p.NombreTipoPrestadorSer)
        .IsRequired()
        .HasMaxLength(100);
    }
}