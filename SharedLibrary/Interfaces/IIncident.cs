using SharedLibrary.Models;

namespace SharedLibrary.Interfaces
{
    public interface IIncident
    {
        Task<Incidents_TBL> AddIncidentAsync(Incidents_TBL model);
        Task<Incidents_TBL> UpdateIncidentAsync(Incidents_TBL model);
        Task<Incidents_TBL> DeleteIncidentAsync(int id);
        Task<List<Incidents_TBL>> GetAllIncidentsAsync();
        Task<Incidents_TBL> GetIncidentByIdAsync(int id);

        Task<bool> IsIncidentRecurringAsync(string location, string incidentName, string reportedBy);
       
    }
}
