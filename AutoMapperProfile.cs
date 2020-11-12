using AutoMapper;
using Yemeksepeti.Dtos.Region;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Models;
using Yemeksepeti.Dtos.Restaurant;
using Yemeksepeti.Dtos.CustomerRegion;

namespace Yemeksepeti{
    public class AutoMapperProfile: Profile{
        public AutoMapperProfile()
        {
            CreateMap<Customer,GetCustomerDto>();
            CreateMap<AddCustomerDto,Customer>();
            CreateMap<UpdateCustomerDto,Customer>();
            CreateMap<Region,GetRegionDto>();
            CreateMap<AddRegionDto,Region>();
            CreateMap<AddRestaurantDto,Restaurant>();
            CreateMap<Restaurant,GetRestaurantDto>();
            CreateMap<ServiceResponse<GetCustomerDto>,Customer>();
            CreateMap<CustomerRegion,GetCustomerRegionDto>();
            
            
        }
    }
}