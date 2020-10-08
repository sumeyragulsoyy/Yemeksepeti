using AutoMapper;
using Yemeksepeti.Dtos.Address;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Models;

namespace Yemeksepeti{
    public class AutoMapperProfile: Profile{
        public AutoMapperProfile()
        {
            CreateMap<Customer,GetCustomerDto>();
            CreateMap<AddCustomerDto,Customer>();
            CreateMap<AddAddressDto,Address>();
            CreateMap<Address,GetAddressDto>();
            
        }
    }
}