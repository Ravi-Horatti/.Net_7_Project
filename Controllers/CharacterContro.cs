using Microsoft.AspNetCore.Mvc;
using New_Project.Models;

namespace New_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterContro : ControllerBase
    {
        private static Charactere knight = new Charactere();


        [HttpGet]
        public ActionResult<Charactere> Get()
        {
            return Ok(knight);
        }
        
    }
}