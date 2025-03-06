using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController(IApplication irepo) : ControllerBase
    {
        private readonly IApplication irepo = irepo;

        [HttpPost("CreateObj")]
        public async Task<ActionResult> CreateObj(ApplicationM obj)
        {
            await irepo.CreateObj(obj);
            return Ok();
        }

        [HttpPut("UpdateObj")]
        public async Task<ActionResult<ApplicationM>> UpdateObj(ApplicationM model)
        {
            var obj = await irepo.UpdateObj(model);
            return Ok(obj);
        }

        [HttpGet("GetAllObj")]
        public async Task<ActionResult<List<ApplicationM>>> GetAllObj()
        {
            var obj = await irepo.GetAllObj();
            return Ok(obj);
        }

        [HttpGet("IsExistUsername")]
        public async Task<ActionResult<bool>> IsExistAbb([FromQuery] string abb)
        {
            var obj = await irepo.IsExistAbb(abb);
            return Ok(obj);
        }

        [HttpPost("CreateUpdateObj")]
        public async Task<ActionResult> CreateUpdateObj(ApplicationM obj)
        {
            await irepo.CreateUpdateObj(obj);
            return Ok();
        }
    }
}
