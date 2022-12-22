using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebProje.DBContext
{
    public class ProductDBContext: DbContext
    {
        public ProductDBContext(DbContextOptions options): base(options) { }
        public DbSet<ProductDBContext> Product { get; set; }
    }
}
