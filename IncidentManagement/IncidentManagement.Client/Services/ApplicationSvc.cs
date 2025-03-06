using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class ApplicationSvc(HttpClient http) : IApplication
    {
        private readonly HttpClient http = http;

        public async Task CreateObj(ApplicationM obj)
        {
            await http.PostAsJsonAsync("/api/Application/CreateObj", obj);
        }  public async Task CreateUpdateObj(ApplicationM obj)
        {
            await http.PostAsJsonAsync("/api/Application/CreateUpdateObj", obj);
        }

        public async Task<ApplicationM> UpdateObj(ApplicationM model)
        {
            var obj = await http.PutAsJsonAsync($"api/Application/UpdateObj", model);
            var response = await obj.Content.ReadFromJsonAsync<ApplicationM>();
            return response;
        }

        public async Task<List<ApplicationM>> GetAllObj()
        {
            var obj = await http.GetAsync("api/Application/GetAllObj");
            var response = await obj.Content.ReadFromJsonAsync<List<ApplicationM>>();
            return response;
        }

        public async Task<bool> IsExistAbb(string abb)
        {
            var obj = await http.GetAsync($"/api/Application/IsExistUsername?abb={abb}");
            var response = await obj.Content.ReadFromJsonAsync<bool>();
            return response;
        }

       
    }
}
