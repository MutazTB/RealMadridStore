using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMadridStore.Models.ViewModel
{
    public class CartVM
    {
        public static List<Product> Products { get; set; }

        static CartVM()
        {
            Products = new List<Product>();
        }
    }
}
