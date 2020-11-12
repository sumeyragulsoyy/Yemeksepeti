using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.Customer;
using Yemeksepeti.Dtos.CustomerRegion;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;

namespace Yemeksepeti.Services
{
    public class CustomerRegionService : ICustomerRegionService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CustomerRegionService(DataContext context,IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _context=context;
            _mapper=mapper;
            _httpContextAccessor=httpContextAccessor;   

        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public Task<ServiceResponse<string>> addAdress(AddCustomerRegionDto address)
        {
            throw new System.NotImplementedException(); 
        }

        public async  Task<ServiceResponse<GetCustomerRegionDto>> getCustomerAddress([FromServices]ICustomerService _customerService)
        {
            ServiceResponse<GetCustomerRegionDto> response= new ServiceResponse<GetCustomerRegionDto>();
            ServiceResponse<GetCustomerDto> response1= await _customerService.getCustomerById(1);
            CustomerRegion customerRegion= await _context.CustomerRegions
                .Include(x =>x.Region)
                .FirstOrDefaultAsync(x => x.CustomerId ==response1.Data.Id); 
            response.Data= _mapper.Map<GetCustomerRegionDto>(customerRegion);
            return response;
        }
    }
}