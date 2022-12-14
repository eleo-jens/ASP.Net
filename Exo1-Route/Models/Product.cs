using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo1_Route.Models
{
    public class Product
    {
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Stock { get; set; }

        public Product(string nom, double prix, int stock)
        {
            Nom = nom;
            Prix = prix;
            Stock = stock;
        }
    }
}
