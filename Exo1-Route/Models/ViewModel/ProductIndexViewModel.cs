using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo1_Route.Models.ViewModel
{
    public class ProductIndexViewModel
    {
        public List<Product> Products { get; set; }

        public ProductIndexViewModel(IEnumerable<Product> products)
        {
            Products = new List<Product>();
            foreach (Product product in products)
            {
                Products.Add(product);
            }
        }
    }
}
