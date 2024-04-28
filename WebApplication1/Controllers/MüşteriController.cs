using Kitap.arama;
using Kitap.arama.Models.DTOs;
using Kitap.arama.MüşteriAbstract;
using Kitap.arama.MüşteriConstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Müşteris = Kitap.arama.Müşteri;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MüşteriController : ControllerBase
    {
        private readonly IMüşteri _ımüşteri;
        public MüşteriController(IMüşteri ımüşteri)
        {
            _ımüşteri = ımüşteri;   
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMüsteri()
        {
            var a = await _ımüşteri.GetAllMüşteri();
            return Ok(a);
        }
        [HttpGet]
        [Route("[action]/(name)")]
        public async Task<IActionResult> GetMusteriName(string names)
        {
            var a = _ımüşteri.GetByMüşteriName(names);
            if(a == null)
            {
                return Ok(names);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("[action]/(id)")]
        public async Task<IActionResult> GetMüsteriID(int id)
        {
            var a= _ımüşteri.GetByMüşteriID(id);
            if(a != null)
            {
                return Ok(a);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> PostMüsteri([FromBody]MüşteriDTO müsteri)
        {
            var a = await _ımüşteri.CreateMüşteri(müsteri);
            return Ok(a);
        }
        [HttpPut]
        public async Task<IActionResult> PutMüsteri([FromBody]Müşteris müsteri)
        {
            if(await _ımüşteri.GetByMüşteriID(müsteri.MüşteriID) != null)
            {
                return Ok(await _ımüşteri.UpdateMüşteri(müsteri));
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMüsteri(int id)
        {
            if (await _ımüşteri.GetByMüşteriID(id)!=null)
            {
                _ımüşteri.DeleteMüşteri(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
