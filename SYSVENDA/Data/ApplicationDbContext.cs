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

        public DbSet<Produto> PRODUTOS { get; set; }
    }
}
