using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalksNew.Models.Domain;
using NZWalksNew.Repositories;

namespace NZWalksNew.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RegionController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionController(IRegionRepository regionRepository,IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        public async Task<IActionResult> GetAllRegion()
        {
            var regions = await regionRepository.GetAll();            
            var RegionsDTO = mapper.Map<List<Models.DTO.Region>>(regions);
            return Ok(RegionsDTO);
        }
    }
}
