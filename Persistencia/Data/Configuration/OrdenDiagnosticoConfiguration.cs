using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class OrdenDiagnosticoConfiguration : IEntityTypeConfiguration<OrdenDiagnostico>
{
    public void Configure(EntityTypeBuilder<OrdenDiagnostico> builder)
    {
        builder.ToTable("OrdenDiagnosticos");

        builder.HasKey(p => p.IdCod);
        builder.Property(p => p.IdCod)
        .ValueGeneratedNever();
        
    }
}