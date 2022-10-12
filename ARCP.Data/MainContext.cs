using ARCP.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ARCP.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
