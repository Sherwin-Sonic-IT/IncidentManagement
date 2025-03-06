using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Interfaces
{
    public interface IMDApi
    {
        Task<List<UserM>> GetAllUsers();
        Task<UserM> GetLoginUser(string username);
        Task UpdateLoginStatus(UserM obj);
        Task<RoleGroupDetailM> GetRoleDetailByGrpId(int id, string appcode);
        Task<List<SystemRoleM>> GetAllSystemRole();
        Task<List<ApplicationM>> GetAllApplication();
        Task<List<RoleGroupDetailM>> GetAllRoleGrpDetail();
        Task<List<RoleGroupHeaderM>> GetAllRoleGrpHeader();

    }
}
