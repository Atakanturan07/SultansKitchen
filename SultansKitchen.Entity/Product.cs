using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Entity
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public decimal Price { get; set; }
    }
}
