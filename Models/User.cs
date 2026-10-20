using System.Text.Json.Serialization;

namespace BlazorUsersJsonPlaceHolderApi.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;

        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        [JsonPropertyName("address")]
        public Address Address { get; set; } = new();

        [JsonPropertyName("company")]
        public Company Company { get; set; } = new();
    }

    public class Address
    {
        [JsonPropertyName("street")]
        public string Street { get; set; } = string.Empty;

        [JsonPropertyName("city")]
        public string City { get; set; } = string.Empty;
    }

    public class Company
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
