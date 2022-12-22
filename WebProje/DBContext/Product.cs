using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProje.DBContext
{
    public class Product
    {
        
        [Key]
        public int id { get; set; }
        [Column("ProductName",TypeName ="Varchar(200)")]
        public string productName { get; set; }
    }
}
