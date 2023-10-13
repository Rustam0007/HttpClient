using System.Net.Http.Json;
using Newtonsoft.Json;

namespace HttpClient2;

public abstract class HttpClientMethod
{
    private static string _apiUri = "https://reqres.in/api/users/2";

    public static async Task<Root?> GetAsyncMethod()
    {
        var httpClient = new HttpClient();
        using var response = await httpClient.GetAsync(_apiUri);
        if (!response.IsSuccessStatusCode) return null;
        
        var content = await response.Content.ReadAsStringAsync();
        var user = JsonConvert.DeserializeObject<Root>(content);
        
        Console.WriteLine("-----GetAsyncMethod-----");
        Console.WriteLine($"Name: {user.Data.First_name}");
        Console.WriteLine($"Phone: {user.Data.Last_name}");
        Console.WriteLine();
        return user;
    }
    
    public static async Task<Root?> GetFromJsonAsyncMethod()
    {
        var httpClient = new HttpClient();

        var user = await httpClient.GetFromJsonAsync<Root>(_apiUri);
        if (user != null)
        {
            Console.WriteLine("-----GetFromJsonAsyncMethod-----");
            Console.WriteLine($"Name: {user.Data.First_name}");
            Console.WriteLine($"Phone: {user.Data.Last_name}");
            Console.WriteLine();
        }
        return user;
    }
    public static async Task<int> PostAsJsonAsyncMethod()
    {
        _apiUri = "https://reqres.in/api/users/2";
        var httpClient = new HttpClient();

        var john = new UserPostReq("John", "Developer");
        var response = await httpClient.PostAsJsonAsync(_apiUri, john);

        var user = await response.Content.ReadFromJsonAsync<UserPostRes>();
        
        Console.WriteLine("-----PostAsJsonAsyncMethod-----");
        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Id: {user.Id}");
        Console.WriteLine();

        return user.Id;
    }
    
    
}