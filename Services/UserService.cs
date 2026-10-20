using System.Net.Http.Json;
using BlazorUsersJsonPlaceHolderApi.Models;

namespace BlazorUsersJsonPlaceHolderApi.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Consome o endpoint https://jsonplaceholder.typicode.com/users
        public async Task<List<User>> GetUsersAsync()
        {
            var users = await _httpClient.GetFromJsonAsync<List<User>>("users");
            return users ?? new List<User>();
        }

        // Retorna a PRIMEIRA pessoa da lista
        public async Task<User?> GetFirstUserAsync()
        {
            var users = await GetUsersAsync();
            return users.FirstOrDefault();
        }

        // Imprime os dados do usuário na tela do console
        public static void PrintUser(User user)
        {
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Cidade: {user.Address.City}");
            Console.WriteLine($"Empresa: {user.Company.Name}");
        }
    }
}
