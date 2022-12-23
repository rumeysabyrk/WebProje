using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz")]
        public string adminAdi { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre giriniz")]
        public string adminSifre { get; set; }
    }
}
