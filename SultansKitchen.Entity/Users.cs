using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Entity
{
    public class Users
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Boş Bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        [MinLength(4,ErrorMessage ="Şifre 4 Karakterden küçük olamaz")]
        [MaxLength(8, ErrorMessage = "Şifre 8 Karakterden büyük olamaz")]

        public string Password { get; set; }

    }
}
