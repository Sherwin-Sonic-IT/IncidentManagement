using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class MDApiSvc(HttpClient http) : IMDApi
    {
        private readonly HttpClient http = http;

        public async Task<List<UserM>> GetAllUsers()
        {
            var obj = await http.GetAsync($"api/MDApi/GetAllUsers");
            var response = await obj.Content.ReadFromJsonAsync<List<UserM>>();
            return response;
        }

        public async Task<UserM> GetLoginUser(string username)
        {
            var obj = await http.GetAsync($"api/MDApi/GetLoginUser?username={username}");
            var response = await obj.Content.ReadFromJsonAsync<UserM>();
            return response;
        }

        public async Task UpdateLoginStatus(UserM obj)
        {
            await http.PutAsJsonAsync($"api/MDApi/UpdateLoginStatus", obj);
        }

        public async Task<RoleGroupDetailM> GetRoleDetailByGrpId(int id, string appcode)
        {
            var obj = await http.GetAsync($"api/MDApi/GetRoleDetailByGrpId?id={id}&appcode={appcode}");
            var response = await obj.Content.ReadFromJsonAsync<RoleGroupDetailM>();
            return response;
        }

        public async Task<List<SystemRoleM>> GetAllSystemRole()
        {
            var obj = await http.GetAsync($"api/MDApi/GetAllSystemRole");
            var response = await obj.Content.ReadFromJsonAsync<List<SystemRoleM>>();
            return response;
        }


        public async Task<List<ApplicationM>> GetAllApplication()
        {
            var obj = await http.GetAsync($"api/MDApi/GetAllApplication");
            var response = await obj.Content.ReadFromJsonAsync<List<ApplicationM>>();
            return response;
        }

        public async Task<List<RoleGroupDetailM>> GetAllRoleGrpDetail()
        {
            var obj = await http.GetAsync($"api/MDApi/GetAllRoleGrpDetail");
            var response = await obj.Content.ReadFromJsonAsync<List<RoleGroupDetailM>>();
            return response;
        }

        public async Task<List<RoleGroupHeaderM>> GetAllRoleGrpHeader()
        {
            var obj = await http.GetAsync($"api/MDApi/GetAllRoleGrpHeader");
            var response = await obj.Content.ReadFromJsonAsync<List<RoleGroupHeaderM>>();
            return response;
        }
    }
}
