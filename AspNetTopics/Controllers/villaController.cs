using AspNetTopics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AspNetTopics.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class villaController : ControllerBase
    {
        private readonly MagicVillaContext db;
        private readonly ILogger<villaController> _logger;

        public villaController(MagicVillaContext db,ILogger<villaController> logger)
        {
            this.db = db;
            this._logger = logger;
        }

        [HttpGet("users")]
        public IActionResult users()
        {
            return Ok(db.LocalUsers.ToList());
        }


        [HttpDelete("delete-Villa/{id}")]
        public async Task<IActionResult> deleteVilla(int id)
        {
            var result = await db.LocalUsers.FirstOrDefaultAsync(x => x.Id == id);

            if(result != null)
            {
                db.LocalUsers.Remove(result);
                await db.SaveChangesAsync();
                return Ok("User deleted");
            }
            else
            {
                return NotFound();
            }
        }
          
    }
}
