using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen bir isminizi giriniz")]
        [MaxLength(50)]
        public string Isim { get; set; }
        [Required(ErrorMessage = "Lütfen bir soyisminizi giriniz")]
        [MaxLength(50)]
        public string SoyIsim { get; set; }
        [Required(ErrorMessage = "Lütfen bir emailinizi giriniz")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifrenizi giriniz")]
        [MaxLength(20)]
        public string Sifre { get; set; }
    }
}
