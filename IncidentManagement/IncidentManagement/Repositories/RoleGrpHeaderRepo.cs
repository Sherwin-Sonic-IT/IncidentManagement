using IncidentManagement.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Repositories
{
    public class RoleGrpHeaderRepo(DataContext context) : IRoleGrpHeader
    {
        private readonly DataContext context = context;

        public async Task<RoleGroupHeaderM> CreateObj(RoleGroupHeaderM obj)
        {
            var newData = context.RoleGroupHeaderM.Add(obj).Entity;
            await context.SaveChangesAsync();
            return newData;
        }

        public async Task<RoleGroupHeaderM> UpdateObj(RoleGroupHeaderM obj)
        {
            var oldObj = await context.RoleGroupHeaderM.FirstOrDefaultAsync(e => e.Id == obj.Id);
            if (obj is null) return null;

            oldObj.RoleName = obj.RoleName;
            await context.SaveChangesAsync();
            return oldObj;
        }

        public async Task<List<RoleGroupHeaderM>> GetAllObj() => await context.RoleGroupHeaderM
            .Include(e => e.RoleGrpDetails).ThenInclude(rd => rd.Application)
            .Include(e => e.RoleGrpDetails).ThenInclude(rd => rd.SystemRole)
                     .AsNoTracking()
            .ToListAsync();

        public async Task<RoleGroupHeaderM> GetSingleObj(int id)
        {
            var obj = await context.RoleGroupHeaderM
                .Include(e => e.RoleGrpDetails).ThenInclude(rd => rd.Application)
                .Include(e => e.RoleGrpDetails).ThenInclude(rd => rd.SystemRole)
                     .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            if (obj is null) return null;

            return obj;
        }

        public async Task<int> GetLastCount() => await context.RoleGroupHeaderM.CountAsync() + 1;

        public async Task<bool> IsExistCode(string code)
        {
            var isExist = await context.RoleGroupHeaderM.FirstOrDefaultAsync(e => e.RoleCode.ToLower() == code.ToLower());
            return isExist is not null;
        }

        public async Task<RoleGroupHeaderM> CreateUpdateObj(RoleGroupHeaderM obj)
        {
            var model = await context.RoleGroupHeaderM.FirstOrDefaultAsync(x => x.RoleCode == obj.RoleCode);
            if (model is null)
            {
                context.RoleGroupHeaderM.Add(obj);
                await context.SaveChangesAsync();
            }
            else
            {
                model.RoleCode = obj.RoleCode;
                model.RoleName = obj.RoleName;
                model.DateCreated = obj.DateCreated;
                await context.SaveChangesAsync();
            }
            return model;
        }

    }
}
