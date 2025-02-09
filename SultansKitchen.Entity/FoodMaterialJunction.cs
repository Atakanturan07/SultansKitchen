using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Entity
{
    public class FoodMaterialJunction
    {
        public int ID { get; set; }
        public int FoodID { get; set; }
        public int MaterialID { get; set; }
        public int UnitID { get; set; }
        public decimal Amount { get; set; }

    }
}
