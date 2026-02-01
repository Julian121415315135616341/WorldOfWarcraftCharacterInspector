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
    
    public async Task<WowCharacter> GetCharacter(string realmSlug, string characterName)
    {
        var accessToken = await GetAccessToken();

        var response = await "https://eu.api.blizzard.com"
            .AppendPathSegments(
                "profile",
                "wow",
                "character",
                realmSlug.ToLowerInvariant(),
                characterName.ToLowerInvariant()
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
    
    public async Task<WowCharacterStats> GetCharacterStats(string realmSlug, string characterName)
    {
        var accessToken = await GetAccessToken();

        var response = await "https://eu.api.blizzard.com"
            .AppendPathSegments(
                "profile",
                "wow",
                "character",
                realmSlug.ToLowerInvariant(),
                characterName.ToLowerInvariant(),
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
    
    public async Task<WowEquipment> GetCharacterEquipment(string realmSlug, string characterName)
    {
        var accessToken = await GetAccessToken();

        var response = await "https://eu.api.blizzard.com"
            .AppendPathSegments(
                "profile",
                "wow",
                "character",
                realmSlug.ToLowerInvariant(),
                characterName.ToLowerInvariant(),
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