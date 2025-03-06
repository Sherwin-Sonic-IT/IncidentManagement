using IncidentManagement.Data;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;

namespace IncidentManagement.Repositories
{
    public class ApplicationRepo(DataContext context) : IApplication
    {
        private readonly DataContext context = context;

        public async Task CreateObj(ApplicationM obj)
        {
            context.ApplicationM.Add(obj);
            await context.SaveChangesAsync();
        }

        public async Task<ApplicationM> UpdateObj(ApplicationM model)
        {
            var obj = await context.ApplicationM.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (obj is null) return null;

            obj.Name = model.Name;
            obj.IP = model.IP;
            obj.Port = model.Port;

            await context.SaveChangesAsync();

            var returnobj = await context.ApplicationM.FirstOrDefaultAsync(x => x.Id == model.Id);
            return returnobj;
        }

        public async Task<List<ApplicationM>> GetAllObj() => await context.ApplicationM.AsNoTracking().ToListAsync();

        public async Task<bool> IsExistAbb(string abb)
        {
            var isExist = await context.ApplicationM.FirstOrDefaultAsync(e => e.Abbreviation.ToLower() == abb.ToLower());
            return isExist is not null;
        }


        public async Task CreateUpdateObj(ApplicationM obj)
        {
            var model = await context.ApplicationM.FirstOrDefaultAsync(x => x.Abbreviation == obj.Abbreviation);
            if (model is null)
            {
                context.ApplicationM.Add(obj);
                await context.SaveChangesAsync();
            }
            else
            {
                model.Abbreviation = obj.Abbreviation;
                model.Name = obj.Name;
                model.Status = obj.Status;
                model.IP = obj.IP;
                model.Port = obj.Port;
                await context.SaveChangesAsync();
            }
        }

    }
}
