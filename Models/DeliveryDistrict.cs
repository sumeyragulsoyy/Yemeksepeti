namespace Yemeksepeti.Models
{
    public class DeliveryDistrict
    {
        
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Explanation { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}