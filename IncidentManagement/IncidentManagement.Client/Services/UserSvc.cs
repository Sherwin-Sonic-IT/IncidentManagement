using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class UserSvc(HttpClient http) : IUser
    {
        private readonly HttpClient http = http;

        #region USERS

        public async Task CreateObj(UserM model)
        {
            await http.PostAsJsonAsync("api/User/CreateObj", model);
        }
        public async Task CreateUpdateObj(UserM model)
        {
            await http.PostAsJsonAsync("api/User/CreateUpdateObj", model);
        }

        public async Task<UserM> DeleteObj(int id)
        {
            var obj = await http.DeleteAsync($"api/User/DeleteObj?id={id}");
            var response = await obj.Content.ReadFromJsonAsync<UserM>();
            return response;
        }

        public async Task<List<UserM>> GetAllObj()
        {
            var obj = await http.GetAsync("api/User/GetAllObj");
            var response = await obj.Content.ReadFromJsonAsync<List<UserM>>();
            return response;
        }

        public async Task<UserM> GetSingleObj(int id)
        {
            var obj = await http.GetAsync($"api/User/GetSingleObj?id={id}");
            var response = await obj.Content.ReadFromJsonAsync<UserM>();
            return response;
        }

        public async Task<int> GetExistCount()
        {
            var obj = await http.GetAsync($"api/User/GetExistCount");
            var response = await obj.Content.ReadFromJsonAsync<int>();
            return response;
        }

        public async Task<UserM> UpdateObj(UserM model)
        {
            var obj = await http.PutAsJsonAsync($"api/User/UpdateObj", model);
            var response = await obj.Content.ReadFromJsonAsync<UserM>();
            return response;
        }

        public async Task<UserM> UpdateObjStatus(UserM model)
        {
            var obj = await http.PutAsJsonAsync($"api/User/UpdateObjStatus", model);
            var response = await obj.Content.ReadFromJsonAsync<UserM>();
            return response;
        }

        public async Task<bool> IsExistUsername(string code, string action, int id)
        {
            var obj = await http.GetAsync($"/api/User/IsExistUsername?code={code}&action={action}&id={id}");
            var response = await obj.Content.ReadFromJsonAsync<bool>();
            return response;
        }

        public async Task<UserM> GetLoginAccount(string username)
        {
            var obj = await http.GetAsync($"/api/User/GetLoginAccount?username={username}");
            var response = await obj.Content.ReadFromJsonAsync<UserM>();
            return response;
        }

        #endregion USERS

    }
}
