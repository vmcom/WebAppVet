using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.Infraestrura.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            builder.ToTable("Profissao");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();
            builder.Property(x => x.Crmv)
                .HasColumnType("varchar(30)")
                .IsRequired();
            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();
        }
    }
}
