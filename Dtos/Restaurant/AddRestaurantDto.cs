using System;

namespace Yemeksepeti.Dtos.Restaurant
{
    public class AddRestaurantDto
    {
        public string Name { get; set; }
        public double ServiceVelocity { get; set; }
        public double Taste { get; set; }
        public double MinBasketAmount { get; set; }
        public int ServiceDuration { get; set; }
        public TimeSpan StartingHour { get; set; }
        public TimeSpan ClosingHour {get;set;}
    }
}