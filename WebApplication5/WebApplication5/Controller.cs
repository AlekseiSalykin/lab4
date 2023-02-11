using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication5
{
    [ApiController]
    [Route("api/controller")]
    public class Controller : ControllerBase
    {
        CityContext db;
        public Controller(CityContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> Get()
        {
            return await db.Cities.Include(x => x.Coords).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<City>> Get(int id)
        {
            City city = await db.Cities.Include(x => x.Coords).FirstOrDefaultAsync(x => x.Id == id);
            if (city == null)
            {
                return NotFound();
            }
            return new ObjectResult(city);
        }
    }
}
