using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class CartItem
    {
        public int Count { get; set; }
        public int GadgetID { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }
}
