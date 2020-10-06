using System.Collections.Generic;

namespace Yemeksepeti.Models
{
    public class MenuCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Menu Menu { get; set; }

    }
}