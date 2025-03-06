using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MDApiController(IMDApi irepo) : ControllerBase
    {
        private readonly IMDApi irepo = irepo;

        [HttpGet("GetAllUsers")]
        public async Task<ActionResult<List<UserM>>> GetAllUsers()
        {
            var obj = await irepo.GetAllUsers();
            return Ok(obj);
        }

        [HttpGet("GetLoginUser")]
        public async Task<ActionResult<UserM>> GetLoginUser(string username)
        {
            var obj = await irepo.GetLoginUser(username);
            return Ok(obj);
        }

        [HttpPut("UpdateLoginStatus")]
        public async Task<ActionResult> UpdateLoginStatus(UserM obj)
        {
            await irepo.UpdateLoginStatus(obj);
            return Ok();
        }

        [HttpGet("GetRoleDetailByGrpId")]
        public async Task<ActionResult<RoleGroupDetailM>> GetRoleDetailByGrpId(int id, string appcode)
        {
            var obj = await irepo.GetRoleDetailByGrpId(id, appcode);
            return Ok(obj);
        }

        [HttpGet("GetAllSystemRole")]
        public async Task<ActionResult<List<SystemRoleM>>> GetAllSystemRole()
        {
            var obj = await irepo.GetAllSystemRole();
            return Ok(obj);
        }


        [HttpGet("GetAllApplication")]
        public async Task<ActionResult<List<ApplicationM>>> GetAllApplication()
        {
            var obj = await irepo.GetAllApplication();
            return Ok(obj);
        }

        [HttpGet("GetAllRoleGrpDetail")]
        public async Task<ActionResult<List<RoleGroupDetailM>>> GetAllRoleGrpDetail()
        {
            var obj = await irepo.GetAllRoleGrpDetail();
            return Ok(obj);
        }

        [HttpGet("GetAllRoleGrpHeader")]
        public async Task<ActionResult<List<RoleGroupHeaderM>>> GetAllRoleGrpHeader()
        {
            var obj = await irepo.GetAllRoleGrpHeader();
            return Ok(obj);
        }
    }
}
