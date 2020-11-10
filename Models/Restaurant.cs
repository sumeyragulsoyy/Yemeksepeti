using System;
using System.Collections.Generic;

namespace Yemeksepeti.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ServiceVelocity { get; set; }
        public double Taste { get; set; }
        public double MinBasketAmount { get; set; }
        public int ServiceDuration { get; set; }
        public TimeSpan WorkingHours { get; set; }
        public List<Comment> Comments { get; set; }
        public Menu Menu { get; set; }
        public CommunicationInfo CommunicationInfo { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}