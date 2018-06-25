using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vet.AppCore.Entity;

namespace Vet.Infraestrura.Data
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            #region Configurações de cliente
            modelBuilder.Entity<Cliente>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Cliente>()
                .HasMany(x => x.Contatos)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.Id);
            #endregion

            #region Configurações de contato
            modelBuilder.Entity<Contato>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Contato>()
                .HasOne(x => x.Cliente)
                .WithMany(x => x.Contatos)
                .HasForeignKey(x => x.ClienteId)
                .HasPrincipalKey(x => x.Id);
            #endregion

            #region Configuração de profissão
            modelBuilder.Entity<Profissao>().Property(x => x.Nome)
                .HasColumnType("varchar(400)")
                .IsRequired();
            modelBuilder.Entity<Profissao>().Property(x => x.Crmv)
                .HasColumnType("varchar(30)")
                .IsRequired();
            modelBuilder.Entity<Profissao>().Property(x => x.Descricao)
                .HasColumnType("varchar(1000)")
                .IsRequired();
            #endregion

            #region Configuração de endereco
            modelBuilder.Entity<Endereco>().Property(x => x.Logradouro)
                .HasColumnType("varchar(400)")
                .IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Bairro)
                .HasColumnType("varchar(300)")
                .IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Cep)
                .HasColumnType("varchar(10)")
                .IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Estado)
                .HasColumnType("varchar(2)")
                .IsRequired();
            modelBuilder.Entity<Endereco>().Property(x => x.Complemento)
                .HasColumnType("varchar(200)");
            #endregion

            #region Configuração de profissão cliente
            modelBuilder.Entity<ProfissaoCliente>().HasKey(x => x.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(x => x.Cliente)
                .WithMany(x => x.Profissoes)
                .HasForeignKey(x => x.ClienteId);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(x => x.Profissao)
                .WithMany(x => x.Profissoes)
                .HasForeignKey(x => x.ProfissaoId);

            #endregion

            #region Configuração de menu
            modelBuilder.Entity<Menu>().HasKey(x => x.Id);
            modelBuilder.Entity<Menu>()
                .HasMany(x => x.SubMenu)
                .WithOne()
                .HasForeignKey(x => x.MenuId);
            
            #endregion
        }

    }
}
