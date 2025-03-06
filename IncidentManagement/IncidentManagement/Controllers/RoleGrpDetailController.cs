using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleGrpDetailController(IRoleGrpDetail irepo) : ControllerBase
    {
        private readonly IRoleGrpDetail irepo = irepo;

        [HttpPost("CreateObj")]
        public async Task<ActionResult> CreateObj(RoleGroupDetailM obj)
        {
            await irepo.CreateObj(obj);
            return Ok();
        }

        [HttpPut("UpdateObj")]
        public async Task<ActionResult> UpdateObj(RoleGroupDetailM obj)
        {
            await irepo.UpdateObj(obj);
            return Ok();
        }

        [HttpGet("GetAllObj")]
        public async Task<ActionResult<List<RoleGroupDetailM>>> GetAllObj()
        {
            var obj = await irepo.GetAllObj();
            return Ok(obj);
        }

        [HttpGet("GetAllObjByGrp")]
        public async Task<ActionResult<List<RoleGroupDetailM>>> GetAllObjByGrp([FromQuery] int id)
        {
            var obj = await irepo.GetAllObjByGrp(id);
            return Ok(obj);
        }
        [HttpGet("GetRoleDetailByGrpId")]
        public async Task<ActionResult<RoleGroupDetailM>> GetRoleDetailByGrpId([FromQuery] int id, [FromQuery] string appcode)
        {
            var obj = await irepo.GetRoleDetailByGrpId(id, appcode);
            return Ok(obj);
        }


        [HttpPost("CreateUpdateObj")]
        public async Task<ActionResult> CreateUpdateObj(RoleGroupDetailM obj)
        {
            await irepo.CreateUpdateObj(obj);
            return Ok();
        }
    }

}
