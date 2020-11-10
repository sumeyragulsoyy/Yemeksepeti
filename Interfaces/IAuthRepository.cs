using System.Threading.Tasks;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user,string password);
        Task<ServiceResponse<string>> Login(string username,string password);
        Task<bool> UserExists(string username); 
    }
}