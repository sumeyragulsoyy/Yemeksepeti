using System.Collections.Generic;

namespace Yemeksepeti.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }               
        public string PhoneNumber { get; set; }
        public List<Address> Addres { get; set; }
        public int Bonus { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
       
        

    }
}