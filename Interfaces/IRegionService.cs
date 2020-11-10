using System.Collections.Generic;
using System.Threading.Tasks;
using Yemeksepeti.Dtos.Region;
using Yemeksepeti.Models;

namespace Yemeksepeti.Interfaces
{
    public interface IRegionService
    {
         public Task<ServiceResponse<List<GetRegionDto>>> getAll() ;
         public Task<ServiceResponse<List<GetRegionDto>>> addRegion(AddRegionDto region );
         
    }
}