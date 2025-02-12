using Microsoft.AspNetCore.SignalR;
using SharedLibrary.Models;

namespace IncidentManagement.Hubs
{
    public class IncidentHub : Hub
    {
        public async Task AddNewIncident(object newIncident)
        {
            await Clients.All.SendAsync("NewIncident", newIncident);
            Console.WriteLine("New incident send to all clients");
        }

        public async Task DeleteIncidentByID(int incidentToDelete)
        {
            await Clients.All.SendAsync("DeleteIncident", incidentToDelete);
            Console.WriteLine("Deleted incident send to all clients");
        }

        public async Task UpdateIncidentByID(object incidentToUpdate)
        {
            await Clients.All.SendAsync("UpdateIncident", incidentToUpdate);
            Console.WriteLine("Updated incident send to all clients");
        }
    }
}
 