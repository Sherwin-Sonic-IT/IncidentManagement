using Newtonsoft.Json;
using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Text;

namespace IncidentManagement.Repositories
{
    public class MDApiRepo : IMDApi
    {
        private static readonly string BaseUrl = "http://192.168.1.19:1112/";

        private static HttpClient GetClient()
        {
            HttpClient client = new();
            client.BaseAddress = new Uri(BaseUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        public async Task<List<UserM>> GetAllUsers()
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/User/GetAllObj");
            var masterdata = JsonConvert.DeserializeObject<List<UserM>>(json);
            return masterdata;
        }

        public async Task UpdateLoginStatus(UserM obj)
        {
            var client = GetClient();
            var json = JsonConvert.SerializeObject(obj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"api/User/UpdateObjStatus", content);
            _ = response.Content.ReadAsStringAsync().Result;
        }

        public async Task<UserM> GetLoginUser(string username)
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/User/GetLoginAccount?username={username}");
            var masterdata = JsonConvert.DeserializeObject<UserM>(json);
            return masterdata;
        }

        public async Task<RoleGroupDetailM> GetRoleDetailByGrpId(int id, string appcode)
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/RoleGrpDetail/GetRoleDetailByGrpId?id={id}&appcode={appcode}");
            var masterdata = JsonConvert.DeserializeObject<RoleGroupDetailM>(json);
            return masterdata;
        }

        public async Task<List<SystemRoleM>> GetAllSystemRole()
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/Constant/GetAllSystemRoles");
            var masterdata = JsonConvert.DeserializeObject<List<SystemRoleM>>(json);
            return masterdata;
        }


        public async Task<List<ApplicationM>> GetAllApplication()
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/Application/GetAllObj");
            var masterdata = JsonConvert.DeserializeObject<List<ApplicationM>>(json);
            return masterdata;
        }

        public async Task<List<RoleGroupDetailM>> GetAllRoleGrpDetail()
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/RoleGrpDetail/GetAllObj");
            var masterdata = JsonConvert.DeserializeObject<List<RoleGroupDetailM>>(json);
            return masterdata;
        }

        public async Task<List<RoleGroupHeaderM>> GetAllRoleGrpHeader()
        {
            var client = GetClient();
            var json = await client.GetStringAsync($"api/RoleGrpHeader/GetAllObj");
            var masterdata = JsonConvert.DeserializeObject<List<RoleGroupHeaderM>>(json);
            return masterdata;
        }
    }
}
