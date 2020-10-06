using System.Collections.Generic;

namespace Yemeksepeti.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public List<MenuCategory> Categories { get; set; } 
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }

    }
}