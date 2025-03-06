using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Interfaces
{
    public interface IApplication
    {
        Task CreateObj(ApplicationM obj);
        Task CreateUpdateObj(ApplicationM obj);
        Task<ApplicationM> UpdateObj(ApplicationM model);
        Task<List<ApplicationM>> GetAllObj();
        Task<bool> IsExistAbb(string abb);
    }
}
