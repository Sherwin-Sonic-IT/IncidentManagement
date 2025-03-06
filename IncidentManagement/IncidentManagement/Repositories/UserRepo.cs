using IncidentManagement.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Repositories
{
    public class UserRepo(DataContext context) : IUser
    {
        private readonly DataContext context = context;

        #region USERS

        public async Task CreateObj(UserM model)
        {
            context.UserM.Add(model);
            await context.SaveChangesAsync();
        }

        public async Task<UserM> DeleteObj(int id)
        {
            var obj = await context.UserM.FirstOrDefaultAsync(x => x.Id == id);
            if (obj is null) return null;

            context.UserM.Remove(obj);
            await context.SaveChangesAsync();
            return obj;
        }

        public async Task<List<UserM>> GetAllObj() => await context.UserM
            .Include(e => e.RoleGroup)
            .Include(e => e.Status)
            .AsNoTracking()
            .ToListAsync();

        public async Task<UserM> GetSingleObj(int id)
        {
            var obj = await context.UserM
            .Include(e => e.RoleGroup)
            .Include(e => e.Status)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
            if (obj is null) return null;

            return obj;
        }

        public async Task<int> GetExistCount() {
            
            var masterList = await context.UserM.ToListAsync();
            if(masterList.Count == 0) return 0;
            return masterList.Count;
        } 

        public async Task<UserM> UpdateObj(UserM model)
        {
            var obj = await context.UserM.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (obj is null) return null;

            obj.FullName = model.FullName;
            obj.Username = model.Username;
            obj.StatusId = model.StatusId;
            obj.RoleGroupId = model.RoleGroupId;
            obj.DateStatus = model.DateStatus;
            obj.IsCantChangePass = model.IsCantChangePass;
            obj.IsPasswordNeverExpires = model.IsPasswordNeverExpires;
            obj.DateUpdated = DateTime.Now;

            await context.SaveChangesAsync();
            var returnobj = await context.UserM.FirstOrDefaultAsync(x => x.Id == model.Id);
            return returnobj;
        }

        public async Task<UserM> UpdateObjStatus(UserM model)
        {
            var obj = await context.UserM.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (obj is null) return null;

            obj.LoginStatus = model.LoginStatus;

            await context.SaveChangesAsync();
            var returnobj = await context.UserM.FirstOrDefaultAsync(x => x.Id == model.Id);
            return returnobj;
        }

        public async Task<bool> IsExistUsername(string code, string action, int id)
        {
            UserM isExist = new();
            if (action == "add")
            {
                isExist = await context.UserM.FirstOrDefaultAsync(e => e.Username.ToLower() == code.ToLower());
            }
            else
            {
                isExist = await context.UserM.FirstOrDefaultAsync(e => e.Username.ToLower() == code.ToLower() && e.Id != id);
            }
            return isExist is not null;
        }

        public async Task<UserM> GetLoginAccount(string username)
        {
            var obj = await context.UserM
                     .Include(e => e.RoleGroup)
                     .Include(e => e.RoleGroup.RoleGrpDetails)
                     .Include(e => e.RoleGroup.RoleGrpDetails).ThenInclude(e => e.Application)
                     .Include(e => e.RoleGroup.RoleGrpDetails).ThenInclude(e => e.SystemRole)
                     .Include(e => e.Status)
                     .AsNoTracking()
                     .FirstOrDefaultAsync(x => x.Username.ToLower() == username.ToLower());
            if (obj is null) return null;

            return obj;
        }


        public async Task CreateUpdateObj(UserM obj)
        {
            var model = await context.UserM.FirstOrDefaultAsync(x => x.UserId == obj.UserId);
            if (model is null)
            {
                context.UserM.Add(obj);
                await context.SaveChangesAsync();
            }
            else
            {
                model.UserId = obj.UserId;
                model.FullName = obj.FullName;
                model.Username = obj.Username;
                model.Password = obj.Password;
                model.StatusId = obj.StatusId;
                //model.LoginStatus = obj.LoginStatus;
                model.RoleGroupId = obj.RoleGroupId;
                model.DateCreated = obj.DateCreated;
                model.DateStatus = obj.DateStatus;
                model.SiteIds = obj.SiteIds;
                model.SiteCodes = obj.SiteCodes;
                model.IsChangePassOnLogin = obj.IsChangePassOnLogin;
                model.IsCantChangePass = obj.IsCantChangePass;
                model.IsPasswordNeverExpires = obj.IsPasswordNeverExpires;
                model.ExpiryDate = obj.ExpiryDate;
                await context.SaveChangesAsync();
            }
        }

        #endregion USERS
    }
}
