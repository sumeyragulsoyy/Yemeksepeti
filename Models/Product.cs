using System.Collections.Generic;

namespace Yemeksepeti.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }      
        public MenuCategory MenuCategory { get; set; }
    }
}