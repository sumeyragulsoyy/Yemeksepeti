namespace Yemeksepeti.Models
{
    public class RestaurantRegion
    {       
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}