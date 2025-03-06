using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class SystemRoleSvc(HttpClient http) : ISystemRole
    {
        private readonly HttpClient http = http;

        public async Task CreateUpdateObj(SystemRoleM obj)
        {
            await http.PostAsJsonAsync("/api/SystemRole/CreateUpdateObj", obj);
        }


        public async Task<List<SystemRoleM>> GetAllObj()
        {
            var obj = await http.GetAsync("api/SystemRole/GetAllObj");
            var response = await obj.Content.ReadFromJsonAsync<List<SystemRoleM>>();
            return response;
        }

        public async Task<SystemRoleM> GetSingleObj(int id)
        {
            var obj = await http.GetAsync($"api/SystemRole/GetSingleObj?id={id}");
            var response = await obj.Content.ReadFromJsonAsync<SystemRoleM>();
            return response;
        }
      
    }
}
