using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Interfaces
{
    public interface ISystemRole
    {
        Task CreateUpdateObj(SystemRoleM obj);

        Task<List<SystemRoleM>> GetAllObj();

        Task<SystemRoleM> GetSingleObj(int id);
    }
}
