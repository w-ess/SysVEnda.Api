using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SysVenda.Domain.Entidades;

namespace SysVenda.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<EstoqueMovimento> EstoqueMovimentos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Garcom> Garcons { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbSet<ComandaItem> ComandaItens { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ClassificacaoPessoa> ClassificacaoPessoas { get; set; }        
    }
}
