using System.Collections.Generic;
using Yemeksepeti.Dtos.Region;

namespace Yemeksepeti.Dtos.Customer
{
    public class GetCustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }               
        public string PhoneNumber { get; set; }
        public int Bonus { get; set; }
        //public List<GetAddressDto> Addres { get; set; }
        

    }
}