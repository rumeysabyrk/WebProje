using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebProje.Models
{
    public class HayvanBarinagiContext:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Hayvan> Hayvan { get; set; }
        public DbSet<Sahiplenme> Sahiplenme { get; set; }
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=HayvanBarinagi;Trusted_Connection=True;");
        }
    }
}
