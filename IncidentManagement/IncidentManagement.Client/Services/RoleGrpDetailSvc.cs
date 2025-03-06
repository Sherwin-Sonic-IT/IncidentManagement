using SharedLibrary.Interfaces;
using SharedLibrary.Models;
using System.Net.Http.Json;

namespace IncidentManagement.Client.Services
{
    public class RoleGrpDetailSvc(HttpClient http) : IRoleGrpDetail
    {
        private readonly HttpClient http = http;

        public async Task CreateObj(RoleGroupDetailM obj)
        {
            await http.PostAsJsonAsync("/api/RoleGrpDetail/CreateObj", obj);
        }

        public async Task CreateUpdateObj(RoleGroupDetailM obj)
        {
            await http.PostAsJsonAsync("/api/RoleGrpDetail/CreateUpdateObj", obj);
        }

        public async Task UpdateObj(RoleGroupDetailM obj)
        {
            await http.PutAsJsonAsync("/api/RoleGrpDetail/UpdateObj", obj);
        }

        public async Task<List<RoleGroupDetailM>> GetAllObj()
        {
            var obj = await http.GetAsync("api/RoleGrpDetail/GetAllObj");
            var response = await obj.Content.ReadFromJsonAsync<List<RoleGroupDetailM>>();
            return response;
        }
        public async Task<List<RoleGroupDetailM>> GetAllObjByGrp(int id)
        {
            var obj = await http.GetAsync($"api/RoleGrpDetail/GetAllObjByGrp?id={id}");
            var response = await obj.Content.ReadFromJsonAsync<List<RoleGroupDetailM>>();
            return response;
        }
        public async Task<RoleGroupDetailM> GetRoleDetailByGrpId(int id, string appcode)
        {
            var obj = await http.GetAsync($"api/RoleGrpDetail/GetRoleDetailByGrpId?id={id}&appcode={appcode}");
            var response = await obj.Content.ReadFromJsonAsync<RoleGroupDetailM>();
            return response;
        }

     
    }
}
