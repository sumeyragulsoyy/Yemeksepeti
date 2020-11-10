namespace Yemeksepeti.Models
{
    public class CustomerRegion
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Region Region { get; set; }
        public int RegionId { get; set; }
        public string AddressDetail { get; set; }
        
    }
}