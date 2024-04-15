using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataWriter.modele
{
    internal class Article
    {
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Article()
        {
            
        }
        public Article(string description, int quantity, double price)
        {
            Description = description;
            Quantity = quantity;
            Price = price;
        }

        public override string ToString()
        {
            return Description + " " + Quantity + " " + Price;
        }
    }
}
