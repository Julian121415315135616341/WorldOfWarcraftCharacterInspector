using Flurl;
using Flurl.Http;
using JulianWow.Models;

namespace JulianWow.Agents;

public class BattleNetAgent(BattleNetAuth battleNetAuth) : IBattleNetAgent
{
    
    
    
    
    
    public async Task<string> GetAccessToken()
    {
        return await battleNetAuth.GetAccessToken();
    }


    public async Task<WowCharacter> GetDruidCharacter()
    {
        var accessToken = await GetAccessToken();

        var response = await "https://eu.api.blizzard.com"
            .AppendPathSegments(
                "profile",
                "wow",
                "character",
                "lightnings-blade",
                "jvlian"
            )
            .SetQueryParams(new
            {
                @namespace = "profile-eu",
                locale = "en_US"
            })
            .WithHeader("Authorization", $"Bearer {accessToken}")
            .GetJsonAsync<WowCharacter>();

        return response;
    }
    
    public async Task<WowCharacterStats> GetDruidStats()
    {
        var accessToken = await GetAccessToken();

        var response = await "https://eu.api.blizzard.com"
            .AppendPathSegments(
                "profile",
                "wow",
                "character",
                "lightnings-blade",
                "jvlian",
                "statistics"
            )
            .SetQueryParams(new
            {
                @namespace = "profile-eu",
                locale = "en_US"
            })
            .WithHeader("Authorization", $"Bearer {accessToken}")
            .GetJsonAsync<WowCharacterStats>();

        return response;
    }
    
    public async Task<WowEquipment> GetDruidEquipment()
    {
        var accessToken = await GetAccessToken();

        var response = await "https://eu.api.blizzard.com"
            .AppendPathSegments(
                "profile",
                "wow",
                "character",
                "lightnings-blade",
                "jvlian",
                "equipment"
            )
            .SetQueryParams(new
            {
                @namespace = "profile-eu",
                locale = "en_US"
            })
            .WithHeader("Authorization", $"Bearer {accessToken}")
            .GetJsonAsync<WowEquipment>();

        return response;
    }
}