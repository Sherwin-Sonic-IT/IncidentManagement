using IncidentManagement.Data;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http;

namespace IncidentManagement.Repositories
{
    public class IncidentRepo : IIncident
    {
        private readonly IDbContextFactory<DataContext> _dbContextFactory;

        public IncidentRepo(IDbContextFactory<DataContext> contextFactory)
        {
            _dbContextFactory = contextFactory;
        }

        public async Task<Incidents_TBL> AddIncidentAsync(Incidents_TBL model)
        {
            if (model == null) return null!;
            using var dbContext = _dbContextFactory.CreateDbContext();
            var check = await dbContext.Incidents_TBL.FirstOrDefaultAsync(_ => _.Incident_ID == model.Incident_ID);
            if (check != null) return null!;
            var addIncident = dbContext.Incidents_TBL.Add(model).Entity;
            await dbContext.SaveChangesAsync();
            return addIncident;
        }

        public async Task<Incidents_TBL> DeleteIncidentAsync(int ID)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var incident = await dbContext.Incidents_TBL.FirstOrDefaultAsync(_ => _.Incident_ID == ID);
            if (incident == null) return null!;
            dbContext.Incidents_TBL.Remove(incident);
            await dbContext.SaveChangesAsync();
            return incident;
        }

        public async Task<List<Incidents_TBL>> GetAllIncidentsAsync()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var incidents = await dbContext.Incidents_TBL.ToListAsync();
            return incidents;
        }

        public async Task<Incidents_TBL> GetIncidentByIdAsync(int ID)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var incident = await dbContext.Incidents_TBL.FirstOrDefaultAsync(_ => _.Incident_ID == ID);
            if (incident == null) return null!;
            return incident;
        }

        public async Task<Incidents_TBL> UpdateIncidentAsync(Incidents_TBL model)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var incident = await dbContext.Incidents_TBL.FirstOrDefaultAsync(_ => _.Incident_ID == model.Incident_ID);
            if (incident == null) return null!;
            incident.Incident_Name = model.Incident_Name;
            incident.Category = model.Category;
            incident.Incident_Date = model.Incident_Date;
            incident.Location = model.Location;
            incident.Date_Reported = model.Date_Reported;
            incident.Reported_By = model.Reported_By;
            incident.Priority = model.Priority;
            incident.Resolver_Name = model.Resolver_Name;
            incident.Status = model.Status;
            await dbContext.SaveChangesAsync();
            return await dbContext.Incidents_TBL.FirstOrDefaultAsync(_ => _.Incident_ID == model.Incident_ID);
        }

        public async Task<bool> IsIncidentRecurringAsync(string location, string incidentName, string reportedBy)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();
            var recurringIncidents = await dbContext.Incidents_TBL
                .Where(i => i.Location == location && i.Incident_Name == incidentName && i.Reported_By == reportedBy)
                .ToListAsync();
            return recurringIncidents.Count > 1;
        }

    }
}





