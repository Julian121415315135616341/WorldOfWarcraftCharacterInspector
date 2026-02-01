using System.Text.Json.Serialization;

namespace JulianWow.Models;

public class WowCharacter
{
    [JsonPropertyName("id")]
    public long Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("level")]
    public int Level { get; set; }
    
    [JsonPropertyName("gender")]
    public Gender Gender { get; set; } = new();
    
    [JsonPropertyName("faction")]
    public Faction Faction { get; set; } = new();
    
    [JsonPropertyName("race")]
    public Race Race { get; set; } = new();
    
    [JsonPropertyName("character_class")]
    public CharacterClass CharacterClass { get; set; } = new();
    
    [JsonPropertyName("active_spec")]
    public ActiveSpec ActiveSpec { get; set; } = new();
    
    [JsonPropertyName("realm")]
    public Realm Realm { get; set; } = new();
    
    [JsonPropertyName("guild")]
    public Guild? Guild { get; set; }
    
    [JsonPropertyName("achievement_points")]
    public int AchievementPoints { get; set; }
    
    [JsonPropertyName("average_item_level")]
    public int AverageItemLevel { get; set; }
    
    [JsonPropertyName("equipped_item_level")]
    public int EquippedItemLevel { get; set; }
}

public class Gender
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class Faction
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class Race
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class CharacterClass
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class ActiveSpec
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class Realm
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("slug")]
    public string Slug { get; set; } = string.Empty;
}

public class Guild
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public long Id { get; set; }
    
    [JsonPropertyName("realm")]
    public Realm Realm { get; set; } = new();
}

