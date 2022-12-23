using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Sahiplenme
    {
        [Key]
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int HayvanId { get; set; }
    }
}
