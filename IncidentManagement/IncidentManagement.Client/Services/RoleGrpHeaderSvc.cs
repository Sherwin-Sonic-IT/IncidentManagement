using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class RoleGrpHeaderSvc : IRoleGrpHeader
    {
        private readonly HttpClient _http;

        public RoleGrpHeaderSvc(HttpClient http)
        {
            _http = http;
        }

        public async Task<RoleGroupHeaderM> CreateObj(RoleGroupHeaderM obj)
        {
            try
            {
                var objres = await _http.PostAsJsonAsync("/api/RoleGrpHeader/CreateObj", obj);
                objres.EnsureSuccessStatusCode(); 
                var response = await objres.Content.ReadFromJsonAsync<RoleGroupHeaderM>();
                return response ?? throw new InvalidOperationException("Failed to deserialize response.");
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error creating object: {ex.Message}");
                throw;
            }
        }

        public async Task<RoleGroupHeaderM> CreateUpdateObj(RoleGroupHeaderM obj)
        {
            try
            {
                var objres = await _http.PostAsJsonAsync("/api/RoleGrpHeader/CreateUpdateObj", obj);
                objres.EnsureSuccessStatusCode();  
                var response = await objres.Content.ReadFromJsonAsync<RoleGroupHeaderM>();
                return response ?? throw new InvalidOperationException("Failed to deserialize response.");
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error creating or updating object: {ex.Message}");
                throw;
            }
        }

        public async Task<RoleGroupHeaderM> UpdateObj(RoleGroupHeaderM model)
        {
            try
            {
                var obj = await _http.PutAsJsonAsync("api/RoleGrpHeader/UpdateObj", model);
                obj.EnsureSuccessStatusCode();
                var response = await obj.Content.ReadFromJsonAsync<RoleGroupHeaderM>();
                return response ?? throw new InvalidOperationException("Failed to deserialize response.");
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error updating object: {ex.Message}");
                throw;
            }
        }

        public async Task<List<RoleGroupHeaderM>> GetAllObj()
        {
            try
            {
                var obj = await _http.GetAsync("api/RoleGrpHeader/GetAllObj");
                obj.EnsureSuccessStatusCode();
                var response = await obj.Content.ReadFromJsonAsync<List<RoleGroupHeaderM>>();
                return response ?? new List<RoleGroupHeaderM>();
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error fetching all objects: {ex.Message}");
                return new List<RoleGroupHeaderM>();
            }
        }

        public async Task<RoleGroupHeaderM> GetSingleObj(int id)
        {
            try
            {
                var obj = await _http.GetAsync($"api/RoleGrpHeader/GetSingleObj?id={id}");
                obj.EnsureSuccessStatusCode();
                var response = await obj.Content.ReadFromJsonAsync<RoleGroupHeaderM>();
                return response ?? throw new InvalidOperationException("Failed to deserialize response.");
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error fetching single object: {ex.Message}");
                throw;
            }
        }

        public async Task<int> GetLastCount()
        {
            try
            {
                var obj = await _http.GetAsync("api/RoleGrpHeader/GetLastCount");
                obj.EnsureSuccessStatusCode();
                var response = await obj.Content.ReadFromJsonAsync<int>();
                return response;
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error fetching last count: {ex.Message}");
                return 0;
            }
        }

        public async Task<bool> IsExistCode(string code)
        {
            try
            {
                var obj = await _http.GetAsync($"api/RoleGrpHeader/IsExistCode?code={code}");
                obj.EnsureSuccessStatusCode();
                var response = await obj.Content.ReadFromJsonAsync<bool>();
                return response;
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"Error checking if code exists: {ex.Message}");
                return false;
            }
        }
    }
}
