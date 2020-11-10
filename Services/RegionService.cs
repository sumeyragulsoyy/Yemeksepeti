using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Yemeksepeti.Data;
using Yemeksepeti.Dtos.Region;
using Yemeksepeti.Interfaces;
using Yemeksepeti.Models;

namespace Yemeksepeti.Services
{
    public class RegionService : IRegionService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public RegionService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetRegionDto>>> addRegion(AddRegionDto region)
        {
            ServiceResponse<List<GetRegionDto>> response = new ServiceResponse<List<GetRegionDto>>();
            Region Region = _mapper.Map<Region>(region);
            await _context.AddAsync(Region);
            await _context.SaveChangesAsync();
            List<Region> regions= await _context.Regions.ToListAsync();
            response.Data=(regions.Select(x => _mapper.Map<GetRegionDto>(x))).ToList();
            return response;
        }

        public async Task<ServiceResponse<List<GetRegionDto>>> getAll()
        {
            ServiceResponse<List<GetRegionDto>> response = new ServiceResponse<List<GetRegionDto>>();
            List<Region> regions= await _context.Regions.ToListAsync();
            response.Data=(regions.Select(x => _mapper.Map<GetRegionDto>(x))).ToList();
            return response;
        }
    }
}