using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Interfaces
{
    public interface IRoleGrpHeader
    {
        Task<RoleGroupHeaderM> CreateObj(RoleGroupHeaderM obj);
        Task<RoleGroupHeaderM> CreateUpdateObj(RoleGroupHeaderM obj);
        Task<RoleGroupHeaderM> UpdateObj(RoleGroupHeaderM obj);
        Task<List<RoleGroupHeaderM>> GetAllObj();
        Task<RoleGroupHeaderM> GetSingleObj(int id);
        Task<bool> IsExistCode(string code);
        Task<int> GetLastCount();

    }
}
