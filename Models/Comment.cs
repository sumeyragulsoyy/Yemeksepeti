using System;

namespace Yemeksepeti.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double ServiceVelocity { get; set; }
        public double Taste { get; set; }
        public int ServiceDuration { get; set; }
        public string Detail { get; set; }
        public Restaurant Restaurant { get; set; }
        
    }
}