using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.Infraestrura.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(c => c.Id);
            builder.Property(x => x.Logradouro)
               .HasColumnType("varchar(400)")
               .IsRequired();
            builder.Property(x => x.Bairro)
                .HasColumnType("varchar(300)")
                .IsRequired();
            builder.Property(x => x.Cep)
                .HasColumnType("varchar(10)")
                .IsRequired();
            builder.Property(x => x.Estado)
                .HasColumnType("varchar(2)")
                .IsRequired();
            builder.Property(x => x.Complemento)
                .HasColumnType("varchar(200)");
        }
    }
}
