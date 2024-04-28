using Kitap.arama;
using Kitap.arama.SubeAbstarct;
using Kitap.arama.SubeConstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using Subes = Kitap.arama.Sube;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubeController : ControllerBase
    {
        private readonly ISubeler _subeler;

        public SubeController(ISubeler subeler)
        {
            _subeler = subeler;
        }
        [HttpGet]
        public async Task<IActionResult> GetSube()
        {
            var sube = _subeler.GetAllSube();
            return Ok(sube);
        }
        [HttpGet]
        [Route("[action]/(id)")]
        public async Task<IActionResult> GetSubeId(int id)
        {
            var sube = _subeler.GetBySubeID(id);
            if (sube != null) {
                return Ok(sube);           
            }
            else { return NotFound(); }

        }
        [HttpPost]
        public async Task<IActionResult> PostSube([FromBody]Subes sube)
        {
            var subecreate =await _subeler.CreateSube(sube);
            return Ok(subecreate);
        }
        [HttpPut]
        public async Task<IActionResult> PutSube([FromBody] Subes sube)
        {
           if(await _subeler.GetBySubeID(sube.ŞubeID) != null)
            {
                return Ok(await _subeler.UpdateSube(sube));
            }
           return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSube(int id)
        {
            if (await _subeler.GetBySubeID(id) != null)
            {
                _subeler.DeleteSube(id);
                return Ok();

            }
               return NotFound() ;
        }
        

    }
}
