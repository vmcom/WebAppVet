using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.Infraestrura.EntityConfig
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.ToTable("Contato");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Contatos)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
