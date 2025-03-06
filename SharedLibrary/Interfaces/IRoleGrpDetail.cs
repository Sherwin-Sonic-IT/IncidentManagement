using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Interfaces
{
    public interface IRoleGrpDetail
    {
        Task CreateObj(RoleGroupDetailM obj);
        Task CreateUpdateObj(RoleGroupDetailM obj);

        Task UpdateObj(RoleGroupDetailM obj);

        Task<List<RoleGroupDetailM>> GetAllObj();

        Task<List<RoleGroupDetailM>> GetAllObjByGrp(int id);

        Task<RoleGroupDetailM> GetRoleDetailByGrpId(int id, string appcode);
    }
}
