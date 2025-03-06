using IncidentManagement.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Repositories
{
    public class RoleGrpDetailRepo(DataContext context) : IRoleGrpDetail
    {
        private readonly DataContext context = context;

        public async Task CreateObj(RoleGroupDetailM obj)
        {
            var oldObj = await context.RoleGroupDetailM.FirstOrDefaultAsync(e => e.ApplicationId == obj.ApplicationId && e.RoleGroupHeaderMId == obj.RoleGroupHeaderMId);
            if (oldObj is null)
            {
                context.RoleGroupDetailM.Add(obj);
                await context.SaveChangesAsync();
            }
        }

        public async Task UpdateObj(RoleGroupDetailM obj)
        {
            var oldObj = await context.RoleGroupDetailM.FirstOrDefaultAsync(e => e.ApplicationId == obj.ApplicationId && e.RoleGroupHeaderMId == obj.RoleGroupHeaderMId);
            if (oldObj is not null)
            {
                oldObj.SystemRoleId = obj.SystemRoleId;
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<RoleGroupDetailM>> GetAllObj() => await context.RoleGroupDetailM
            .Include(e => e.Application)
            .Include(e => e.SystemRole)
            .OrderBy(e => e.ApplicationId)
            .AsNoTracking()
            .ToListAsync();

        public async Task<List<RoleGroupDetailM>> GetAllObjByGrp(int id) => await context.RoleGroupDetailM
            .Include(e => e.Application)
            .Include(e => e.SystemRole)
            .Where(e => e.RoleGroupHeaderMId == id)
            .AsNoTracking()
            .OrderBy(e => e.ApplicationId).ToListAsync();

        public async Task<RoleGroupDetailM> GetRoleDetailByGrpId(int id, string appcode) => await context.RoleGroupDetailM
                .Include(e => e.Application)
                .Include(e => e.SystemRole)
                 .AsNoTracking()
                .FirstOrDefaultAsync(e => e.RoleGroupHeaderMId == id && e.Application.Abbreviation == appcode);


        public async Task CreateUpdateObj(RoleGroupDetailM obj)
        {
            var model = await context.RoleGroupDetailM.FirstOrDefaultAsync(x => x.RoleGroupHeaderMId == obj.RoleGroupHeaderMId && x.ApplicationId == obj.ApplicationId);
            if (model is null)
            {
                context.RoleGroupDetailM.Add(obj);
                await context.SaveChangesAsync();
            }
            else
            {
                model.RoleGroupHeaderMId = obj.RoleGroupHeaderMId;
                model.ApplicationId = obj.ApplicationId;
                model.SystemRoleId = obj.SystemRoleId;
                await context.SaveChangesAsync();
            }
        }
    }

}
