using Microsoft.AspNetCore.Mvc;
using Tutorial.Data;
using Tutorial.Models.Dto;

namespace Tutorial.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok( VillaStore.VillaList);
        }

        [HttpGet("{id:int}")]
        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.VillaList.FirstOrDefault(u=>u.Id==id);
            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }
    }
}
