namespace Yemeksepeti.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public Customer Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        
    }
}