using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.Address;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;

namespace Yemeksepeti.Services
{
    public class AddressService : IAddressService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AddressService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<GetAddressDto>> addAddress(AddAddressDto Address)
        {
            ServiceResponse<GetAddressDto> response= new ServiceResponse<GetAddressDto>();

            Address address= _mapper.Map<Address>(Address);
            address.Customer= await _context.Customers.FirstOrDefaultAsync(x =>x.Id ==8 );
            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();

            response.Data=_mapper.Map<GetAddressDto>(address);
            return response;
        }
    }
}