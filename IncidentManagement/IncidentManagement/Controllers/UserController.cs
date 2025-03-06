using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUser irepo) : ControllerBase
    {
        private readonly IUser irepo = irepo;

        #region USERS

        [HttpPost("CreateObj")]
        public async Task<ActionResult> CreateObj(UserM model)
        {
            await irepo.CreateObj(model);
            return Ok();
        }

        [HttpPut("UpdateObj")]
        public async Task<ActionResult<UserM>> UpdateObj(UserM model)
        {
            var obj = await irepo.UpdateObj(model);
            return Ok(obj);
        }

        [HttpPut("UpdateObjStatus")]
        public async Task<ActionResult<UserM>> UpdateObjStatus(UserM model)
        {
            var obj = await irepo.UpdateObjStatus(model);
            return Ok(obj);
        }

        [HttpDelete("DeleteObj")]
        public async Task<ActionResult<UserM>> DeleteObj([FromQuery] int id)
        {
            var obj = await irepo.DeleteObj(id);
            return Ok(obj);
        }

        [HttpGet("GetAllObj")]
        public async Task<ActionResult<List<UserM>>> GetAllObj()
        {
            var obj = await irepo.GetAllObj();
            return Ok(obj);
        }

        [HttpGet("GetSingleObj")]
        public async Task<ActionResult<UserM>> GetSingleObj([FromQuery] int id)
        {
            var obj = await irepo.GetSingleObj(id);
            return Ok(obj);
        }

        [HttpGet("GetExistCount")]
        public async Task<ActionResult<int>> GetExistCount()
        {
            var obj = await irepo.GetExistCount();
            return Ok(obj);
        }

        [HttpGet("IsExistUsername")]
        public async Task<ActionResult<bool>> IsExistUsername([FromQuery] string code, [FromQuery] string action, [FromQuery] int id)
        {
            var obj = await irepo.IsExistUsername(code, action, id);
            return Ok(obj);
        }

        [HttpGet("GetLoginAccount")]
        public async Task<ActionResult<UserM>> GetLoginAccount([FromQuery] string username)
        {
            var obj = await irepo.GetLoginAccount(username);
            return Ok(obj);
        }


        [HttpPost("CreateUpdateObj")]
        public async Task<ActionResult> CreateUpdateObj(UserM obj)
        {
            await irepo.CreateUpdateObj(obj);
            return Ok();
        }

        #endregion USERS
    }
       
}
