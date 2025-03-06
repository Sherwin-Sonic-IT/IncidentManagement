using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.AuthenticationInterface
{
    public interface IAuthenticationInterface
    {
        Task<(int UserId, string UserName, string UserRole, bool IsAdmin, string Location)> AuthenticateUser();
    }
}
