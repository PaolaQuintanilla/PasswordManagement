using PasswordManagement.DataModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace PasswordManagement.Services
{
    public class PasswordService : IPasswordService
    {
        private readonly HttpClient _httpClient;

        public PasswordService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<PasswordModel> CreatePassword(PasswordModel password)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/Password/Create/", password);
            return await result.Content.ReadFromJsonAsync<PasswordModel>();
        }

        public async Task<string> DeletePassword(int id)
        {
            await _httpClient.DeleteAsync($"api/Password/Delete/{id}");
            return "";
        }

        public async Task<List<PasswordModel>> GetPasswords()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<PasswordModel>>(@$"api/Password/getPasswords/");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<string> UpdatePassword(PasswordModel password)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Password/Update/{password.Id}", password);
            return "";
        }
    }
}
