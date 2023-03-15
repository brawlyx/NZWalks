using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet] 
        public IActionResult GetAllRegions() {

            /* var regions = new List<Region>()                         //this is a static list, this will be removed because
                {                                                          we are getting data from the database          
                    new Region
                    {
                        Id = Guid.NewGuid(),
                        Name = "Wellington",
                        Code = "WLG",
                        Area = 227755,
                        Lat = -1.8822,
                        Long = 299.88,
                        Population = 500000
                    },
                    new Region
                    { 
                        Id = Guid.NewGuid(),
                        Name = "Auckland",
                        Code = "AUCK",
                        Area = 227755,
                        Lat = -1.8822,
                        Long = 299.88,
                        Population = 500000

                    }

                };
                */
            var regions = regionRepository.GetAll();
            return Ok(regions); 
        }

    }
}
