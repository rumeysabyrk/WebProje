using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Hayvanlar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Hayvan Adı ")]
        public string HayvanAdi { get; set; }
        public string HayvanResim { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Hayvan Türü ")]
        public string Tur { get; set; }
        public bool Sahiplenildimi { get; set; }
    }
}
