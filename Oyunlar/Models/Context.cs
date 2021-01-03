using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oyunlar.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .;" +
                "database=Oyunlar2; integrated security=true;");
        }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Oyun> Oyuns { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Degerlendirme> Degerlendirmes { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
    }
}
