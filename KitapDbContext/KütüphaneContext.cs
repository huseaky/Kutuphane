
using Kütüphane.Entitiy;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitap.arama
{
    public class KütüphaneContext:DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server = DESKTOP-4GLN31H\\SQLEXPRESS; Database = Kütüphane; Trusted_Connection = True;Trust Server Certificate=True;");

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<KütüphaneContext> Kütüphanes { get; set; }

        public DbSet<Worder> Worders { get; set; }

        public DbSet<Sube> Subes { get; set; }

        public DbSet<Müşteri> Müşteris { get; set; }


    }
}
