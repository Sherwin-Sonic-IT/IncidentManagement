//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.SignalR.Client;
//using SharedLibrary.Interfaces;
//using SharedLibrary.Models;
//using System.Net.Http.Json;

//namespace IncidentManagement.Client.Services
//{
//    public class IncidentService : IIncident
//    {
//        private readonly HttpClient httpClient;
//        public IncidentService(HttpClient httpClient)
//        {
//            this.httpClient = httpClient;
//        }

//        public async Task<Incidents_TBL> AddIncidentAsync(Incidents_TBL model)
//        {
//            var incident = await httpClient.PostAsJsonAsync("api/Incident/Add-Incident", model);
//            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
//            return response!;
//        }

//        public async Task<Incidents_TBL> DeleteIncidentAsync(int ID)
//        {
//            var incident = await httpClient.DeleteAsync($"api/Incident/Delete-Incident/{ID}");
//            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
//            return response!;
//        }

//        public async Task<List<Incidents_TBL>> GetAllIncidentsAsync()
//        {
//            var incident = await httpClient.GetAsync("api/Incident/All-Incidents");
//            var response = await incident.Content.ReadFromJsonAsync<List<Incidents_TBL>>();
//            return response!;
//        }

//        public async Task<Incidents_TBL> GetIncidentByIdAsync(int ID)
//        {
//            var incident = await httpClient.GetAsync($"api/Incident/Get-Incident/{ID}");
//            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
//            return response!;
//        }

//        public async Task<Incidents_TBL> UpdateIncidentAsync(Incidents_TBL model)
//        {
//            var incident = await httpClient.PutAsJsonAsync("api/Incident/Update-Incident", model);
//            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
//            return response!;
//        }

//        public async Task<bool> IsIncidentRecurringAsync(string location, string incidentName, string reportedBy)
//        {
//            var incidents = await httpClient.GetAsync("api/Incident/All-Incidents");
//            var allIncidents = await incidents.Content.ReadFromJsonAsync<List<Incidents_TBL>>();

//            var recurringIncidents = allIncidents.Where(i =>
//                i.Location == location && i.Incident_Name == incidentName && i.Reported_By == reportedBy).ToList();

//            return recurringIncidents.Count > 1;
//        }


//    }
//}






using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class IncidentService : IIncident
    {
        private readonly HttpClient _httpClient;

        public IncidentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Incidents_TBL> AddIncidentAsync(Incidents_TBL model)
        {
            var incident = await _httpClient.PostAsJsonAsync("api/Incident/Add-Incident", model);
            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
            return response!;
        }

        public async Task<Incidents_TBL> DeleteIncidentAsync(int ID)
        {
            var incident = await _httpClient.DeleteAsync($"api/Incident/Delete-Incident/{ID}");
            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
            return response!;
        }

        public async Task<List<Incidents_TBL>> GetAllIncidentsAsync()
        {
            var response = await _httpClient.GetAsync("api/Incident/All-Incidents");
            var incidents = await response.Content.ReadFromJsonAsync<List<Incidents_TBL>>();
            return incidents!;
        }

        public async Task<Incidents_TBL> GetIncidentByIdAsync(int ID)
        {
            var incident = await _httpClient.GetAsync($"api/Incident/Get-Incident/{ID}");
            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
            return response!;
        }

        public async Task<Incidents_TBL> UpdateIncidentAsync(Incidents_TBL model)
        {
            var incident = await _httpClient.PutAsJsonAsync("api/Incident/Update-Incident", model);
            var response = await incident.Content.ReadFromJsonAsync<Incidents_TBL>();
            return response!;
        }

        public async Task<bool> IsIncidentRecurringAsync(string location, string incidentName, string reportedBy)
        {
            var incidents = await _httpClient.GetAsync("api/Incident/All-Incidents");
            var allIncidents = await incidents.Content.ReadFromJsonAsync<List<Incidents_TBL>>();

            var recurringIncidents = allIncidents.Where(i =>
                i.Location == location && i.Incident_Name == incidentName && i.Reported_By == reportedBy).ToList();

            return recurringIncidents.Count > 1;
        }
      
    }
}




