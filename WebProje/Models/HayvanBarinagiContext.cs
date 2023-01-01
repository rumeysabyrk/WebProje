using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProje.Models;

namespace WebProje.Models
{
    public class HayvanBarinagiContext:DbContext
    {
        public DbSet<Hayvanlar> Hayvan { get; set; }
        public DbSet<Sahiplenme> Sahiplenme { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Deneme;Trusted_Connection=True;");
        }
    }
}
