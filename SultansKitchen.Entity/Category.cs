using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Entity
{
    public class Category
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        public byte[] Image { get; set; }
 
    }
}
