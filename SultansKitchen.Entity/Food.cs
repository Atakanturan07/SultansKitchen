using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SultansKitchen.Entity
{
    public class Food
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }

        public byte[] Image { get; set; }

        public int Level { get; set; }

        public decimal Calory { get; set; }

        public int Capacity { get; set; }

        public string Description { get; set; }

        public int CookTime { get; set; }

        public int CookTypeID { get; set; }
    }
}
