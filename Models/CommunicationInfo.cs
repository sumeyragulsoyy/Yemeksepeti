namespace Yemeksepeti.Models
{
    public class CommunicationInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string CRSN { get; set; }
        public string PhoneNumber { get; set; }       
        public Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
    }
}