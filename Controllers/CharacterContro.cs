using Microsoft.AspNetCore.Mvc;
using New_Project.Models;

namespace New_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterContro : ControllerBase
    {
        private static List<Charactere> characters = new List<Charactere>()
        {
            new Charactere(),
            new Charactere{Name="SAMMY"}

        };


        [HttpGet("GetAll")]
        public ActionResult<List<Charactere>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<List<Charactere>> GetSingle()
        {
            return Ok(characters[0]);
        }
        
    }
}