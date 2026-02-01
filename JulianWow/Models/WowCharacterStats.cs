using System.Text.Json.Serialization;

namespace JulianWow.Models;

public class WowCharacterStats
{
    [JsonPropertyName("health")]
    public double Health { get; set; }
    
    [JsonPropertyName("power")]
    public double Power { get; set; }
    
    [JsonPropertyName("power_type")]
    public PowerType PowerType { get; set; } = new();
    
    [JsonPropertyName("speed")]
    public StatRating Speed { get; set; } = new();
    
    [JsonPropertyName("strength")]
    public BaseStat Strength { get; set; } = new();
    
    [JsonPropertyName("agility")]
    public BaseStat Agility { get; set; } = new();
    
    [JsonPropertyName("intellect")]
    public BaseStat Intellect { get; set; } = new();
    
    [JsonPropertyName("stamina")]
    public BaseStat Stamina { get; set; } = new();
    
    [JsonPropertyName("melee_crit")]
    public StatValue MeleeCrit { get; set; } = new();
    
    [JsonPropertyName("melee_haste")]
    public StatValue MeleeHaste { get; set; } = new();
    
    [JsonPropertyName("mastery")]
    public StatValue Mastery { get; set; } = new();
    
    [JsonPropertyName("versatility")]
    public double Versatility { get; set; }
    
    [JsonPropertyName("versatility_damage_done_bonus")]
    public double VersatilityDamageDoneBonus { get; set; }
    
    [JsonPropertyName("versatility_healing_done_bonus")]
    public double VersatilityHealingDoneBonus { get; set; }
    
    [JsonPropertyName("spell_power")]
    public double SpellPower { get; set; }
    
    [JsonPropertyName("spell_crit")]
    public StatValue SpellCrit { get; set; } = new();
    
    [JsonPropertyName("spell_haste")]
    public StatValue SpellHaste { get; set; } = new();
    
    [JsonPropertyName("mana_regen")]
    public double ManaRegen { get; set; }
    
    [JsonPropertyName("armor")]
    public ArmorStat Armor { get; set; } = new();
    
    [JsonPropertyName("dodge")]
    public StatValue Dodge { get; set; } = new();
}

public class PowerType
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class BaseStat
{
    [JsonPropertyName("base")]
    public int Base { get; set; }
    
    [JsonPropertyName("effective")]
    public int Effective { get; set; }
}

public class StatRating
{
    [JsonPropertyName("rating_bonus")]
    public double RatingBonus { get; set; }
    
    [JsonPropertyName("rating_normalized")]
    public int RatingNormalized { get; set; }
}

public class StatValue
{
    [JsonPropertyName("rating_bonus")]
    public double RatingBonus { get; set; }
    
    [JsonPropertyName("value")]
    public double Value { get; set; }
    
    [JsonPropertyName("rating_normalized")]
    public int RatingNormalized { get; set; }
}

public class ArmorStat
{
    [JsonPropertyName("base")]
    public int Base { get; set; }
    
    [JsonPropertyName("effective")]
    public int Effective { get; set; }
}

