using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleGrpHeaderController(IRoleGrpHeader irepo) : ControllerBase
    {
        private readonly IRoleGrpHeader irepo = irepo;

        [HttpPost("CreateObj")]
        public async Task<ActionResult<RoleGroupHeaderM>> CreateObj(RoleGroupHeaderM obj)
        {
            var newData = await irepo.CreateObj(obj);
            return Ok(newData);
        }

        [HttpPut("UpdateObj")]
        public async Task<ActionResult<RoleGroupHeaderM>> UpdateObj(RoleGroupHeaderM model)
        {
            var obj = await irepo.UpdateObj(model);
            return Ok(obj);
        }

        [HttpGet("GetAllObj")]
        public async Task<ActionResult<List<RoleGroupHeaderM>>> GetAllObj()
        {
            var obj = await irepo.GetAllObj();
            return Ok(obj);
        }

        [HttpGet("GetSingleObj")]
        public async Task<ActionResult<RoleGroupHeaderM>> GetSingleObj([FromQuery] int id)
        {
            var obj = await irepo.GetSingleObj(id);
            return Ok(obj);
        }

        [HttpGet("GetLastCount")]
        public async Task<ActionResult<int>> GetLastCount()
        {
            var obj = await irepo.GetLastCount();
            return Ok(obj);
        }

        [HttpGet("IsExistUsername")]
        public async Task<ActionResult<bool>> IsExistCode([FromQuery] string code)
        {
            var obj = await irepo.IsExistCode(code);
            return Ok(obj);
        }

        [HttpPost("CreateUpdateObj")]
        public async Task<ActionResult> CreateUpdateObj(RoleGroupHeaderM obj)
        {
            await irepo.CreateUpdateObj(obj);
            return Ok();
        }
    }
}
