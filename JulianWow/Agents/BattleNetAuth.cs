using System.Text;
using System.Text.Json;
using Flurl;
using Flurl.Http;

namespace JulianWow.Agents;

public class BattleNetAuth(IConfiguration configuration)
{
    private readonly string clientId = Environment.GetEnvironmentVariable("ClientId")
                                       ?? configuration["BattleNetApi:ClientId"];
    
    private readonly string clientSecret = Environment.GetEnvironmentVariable("ClientSecret")
                                       ?? configuration["BattleNetApi:ClientSecret"];


    public async Task<string> GetAccessToken()
    {
        var authHeader = Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}")
        );

        var response = await "https://oauth.battle.net"
            .AppendPathSegment("token")
            .WithHeader("Authorization", $"Basic {authHeader}")
            .PostUrlEncodedAsync(new
            {
                grant_type = "client_credentials"
            })
            .ReceiveJson<JsonElement>();
        
        return response
            .GetProperty("access_token")
            .GetString()!;
    }
}