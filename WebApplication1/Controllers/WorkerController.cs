using Kitap.arama;
using Kitap.arama.AbstractWorker;
using Kitap.arama.ConstractWorker;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorker _ıworker;
        public WorkerController(IWorker ıwoerker)
        {
            ıwoerker = _ıworker; 
        }
        [HttpGet]
        public async Task<IActionResult> GetWorker()
        {
            var a = _ıworker.GetAllWorker();
            return Ok(a);
        }
        [HttpGet]
        [Route("[action]/(name)")]
        public async Task<IActionResult> Getworkername(string name)
        {
            var a = _ıworker.GetWorkerByName(name);
            if (a != null) 
            {
                return Ok(a);
            }
            return NotFound();
        }
        [HttpGet]
        [Route("[action]/(id)")]
        public async Task<IActionResult> GetWorkerId(int id)
        {
            var a =_ıworker.GetWorkerById(id);
            if (a != null)
            {
                return Ok(a);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> PostWorker([FromBody]Worder worder)
        {
            var a = await _ıworker.CreateWorker(worder);
            return Ok(a);

        }
        [HttpPut]
        public async Task<IActionResult> PutWorker([FromBody] Worder worder)
        {
            if( await _ıworker.GetWorkerById(worder.WorkerID) != null)
            {
                return Ok(await _ıworker.UpdateWorker(worder));
            }
            return NotFound();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorker(int id)
        {
            if(await _ıworker.GetWorkerById(id) != null)
            {
                _ıworker.DeleteWorker(id);
                    return Ok();
            }
            return NotFound();
        }


    }
}
