using IncidentManagement.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Repositories
{
    public class SystemRoleRepo(IDbContextFactory<DataContext> instance) : ISystemRole
    {
        private readonly DataContext context = instance.CreateDbContext();

        public async Task CreateUpdateObj(SystemRoleM obj)
        {
            var model = await context.SystemRoleM.FirstOrDefaultAsync(x => x.RoleCode == obj.RoleCode);
            if (model is null)
            {
                context.SystemRoleM.Add(obj);
                await context.SaveChangesAsync();
            }
            else
            {
                model.RoleCode = obj.RoleCode;
                model.RoleName = obj.RoleName;
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<SystemRoleM>> GetAllObj() => await context.SystemRoleM.ToListAsync();

        public async Task<SystemRoleM> GetSingleObj(int id)
        {
            var obj = await context.SystemRoleM.FirstOrDefaultAsync(x => x.Id == id);
            if (obj is null) return null;

            return obj;
        }

    }
}
