using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI_DotNet8.Entities;

namespace SuperHeroAPI_DotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Sipderman",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York"
                }

            };

            return Ok(heroes);
        }

    }
}




