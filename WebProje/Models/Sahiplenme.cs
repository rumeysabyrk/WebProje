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
        public int HayvanId { get; set; }
        [Required]
        public string isim { get; set; }
        [Required]
        public string soyIsim { get; set; }
        [Required]
        [MaxLength(11)]
        public string TC { get; set; }
        [Required]
        public DateTime dogumTarihi { get; set; }
        [Required]
        [MaxLength(200)]
        public string adres { get; set; }
        [Required]
        public string soru1 { get; set; }
        [Required]
        public string soru2 { get; set; }
        [Required]
        public string soru3 { get; set; }
        [Required]
        public string soru4 { get; set; }

    }
}
