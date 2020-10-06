namespace Yemeksepeti.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Explanation { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}