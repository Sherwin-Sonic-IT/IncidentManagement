using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Interfaces
{
    public interface IUser
    {
        #region USERS

        Task CreateObj(UserM model);
        Task CreateUpdateObj(UserM model);

        Task<UserM> UpdateObj(UserM model);

        Task<UserM> UpdateObjStatus(UserM model);

        Task<UserM> DeleteObj(int id);

        Task<List<UserM>> GetAllObj();

        Task<UserM> GetSingleObj(int id);

        Task<int> GetExistCount();

        Task<bool> IsExistUsername(string code, string action, int id);

        Task<UserM> GetLoginAccount(string username);

        #endregion USERS

    }
}

