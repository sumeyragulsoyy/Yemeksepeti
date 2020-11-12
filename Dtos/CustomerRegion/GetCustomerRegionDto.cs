using Yemeksepeti.Dtos.Region;

namespace Yemeksepeti.Dtos.CustomerRegion
{
    public class GetCustomerRegionDto
    {
        public string AddressDetail { get; set; }
        public bool IsSelected { get; set; }
        public GetRegionDto region { get; set; }  
    }
}