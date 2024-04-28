using Kitap.arama.Abstarct;
using Kütüphane.Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        private readonly IKitap _ıkitap;

        public KitapController(IKitap ıkitap)
        {
            _ıkitap = ıkitap;
        }

        [HttpGet]
        public async Task<IActionResult> GetKitap()
        {
            var kitap = await _ıkitap.GetAllKitap();
            return Ok(kitap);
        }
        [HttpGet]
        [Route("[action]/(id)")]
        public async Task<IActionResult>GetKitapById(int id)
        {
            var kitap = await _ıkitap.GetKitapById(id);
                if(kitap != null)
            {
                return Ok(kitap);
            }
                return NotFound();
        }
        [HttpGet]
        [Route("[action]/(name)")]
        public async Task <IActionResult> GetKitapByName(string name)
        {
            var kitap = await _ıkitap.GetKitapByName(name);
            if(kitap != null)
            {
                return Ok(kitap);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> PostKitap([FromBody]Book book )
        {
            var createdKitap = await _ıkitap.CreateKitap(book);
            return Ok(createdKitap);

        
        }
        [HttpPut]
        public async Task<IActionResult> PutKitap([FromBody]Book book)
        {
            if(await _ıkitap.GetKitapById(book.ID) != null)
            {
                return Ok(await _ıkitap.UpdateKitap(book));
            }
           
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKitap(int id)
        {
            if(await _ıkitap.GetKitapById(id) != null)
            {
                _ıkitap.DeleteKitap(id);
                return Ok();
            }
            return NotFound();
        }

    }
}
