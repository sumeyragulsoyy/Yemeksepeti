using AutoMapper;
using Yemeksepeti.Dtos.Region;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Models;

namespace Yemeksepeti{
    public class AutoMapperProfile: Profile{
        public AutoMapperProfile()
        {
            CreateMap<Customer,GetCustomerDto>();
            CreateMap<AddCustomerDto,Customer>();
            CreateMap<UpdateCustomerDto,Customer>();
            CreateMap<Region,GetRegionDto>();
            CreateMap<AddRegionDto,Region>();
            
            
        }
    }
}