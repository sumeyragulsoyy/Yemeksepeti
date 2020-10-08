using AutoMapper;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Models;

namespace Yemeksepeti{
    public class AutoMapperProfile: Profile{
        public AutoMapperProfile()
        {
            CreateMap<Customer,GetCustomerDto>();

        }
    }
}