using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemRoleController(ISystemRole irepo) : ControllerBase
    {
        private readonly ISystemRole irepo = irepo;

        [HttpPost("CreateUpdateObj")]
        public async Task<ActionResult> CreateUpdateObj(SystemRoleM obj)
        {
            await irepo.CreateUpdateObj(obj);
            return Ok();
        }

        [HttpGet("GetAllObj")]
        public async Task<ActionResult<List<SystemRoleM>>> GetAllObj()
        {
            var obj = await irepo.GetAllObj();
            return Ok(obj);
        }

        [HttpGet("GetSingleObj")]
        public async Task<ActionResult<SystemRoleM>> GetSingleObj([FromQuery] int id)
        {
            var obj = await irepo.GetSingleObj(id);
            return Ok(obj);
        }
    }
}
