using System.Text.Json.Serialization;

namespace JulianWow.Models;

public class WowEquipment
{
    [JsonPropertyName("equipped_items")]
    public List<EquippedItem> EquippedItems { get; set; } = new();
}

public class EquippedItem
{
    [JsonPropertyName("item")]
    public ItemReference Item { get; set; } = new();
    
    [JsonPropertyName("slot")]
    public ItemSlot Slot { get; set; } = new();
    
    [JsonPropertyName("quality")]
    public ItemQuality Quality { get; set; } = new();
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("level")]
    public ItemLevel? Level { get; set; }
    
    [JsonPropertyName("media")]
    public MediaReference? Media { get; set; }
    
    [JsonPropertyName("item_class")]
    public ItemClass ItemClass { get; set; } = new();
    
    [JsonPropertyName("item_subclass")]
    public ItemSubclass ItemSubclass { get; set; } = new();
    
    [JsonPropertyName("sockets")]
    public List<Socket>? Sockets { get; set; }
    
    [JsonPropertyName("name_description")]
    public NameDescription? NameDescription { get; set; }
    
    [JsonPropertyName("stats")]
    public List<ItemStat>? Stats { get; set; }
    
    [JsonPropertyName("armor")]
    public ArmorValue? Armor { get; set; }
    
    [JsonPropertyName("weapon")]
    public WeaponInfo? Weapon { get; set; }
    
    [JsonPropertyName("spells")]
    public List<ItemSpell>? Spells { get; set; }
    
    [JsonPropertyName("set")]
    public ItemSetInfo? Set { get; set; }
}

public class ItemReference
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class ItemSlot
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class ItemQuality
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class ItemLevel
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
    
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class MediaReference
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class ItemClass
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class ItemSubclass
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class Socket
{
    [JsonPropertyName("socket_type")]
    public SocketType SocketType { get; set; } = new();
    
    [JsonPropertyName("item")]
    public SocketItem? Item { get; set; }
}

public class SocketType
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class SocketItem
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class NameDescription
{
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class ItemStat
{
    [JsonPropertyName("type")]
    public StatType Type { get; set; } = new();
    
    [JsonPropertyName("value")]
    public int Value { get; set; }
    
    [JsonPropertyName("is_negated")]
    public bool IsNegated { get; set; }
    
    [JsonPropertyName("is_equip_bonus")]
    public bool IsEquipBonus { get; set; }
    
    [JsonPropertyName("display")]
    public StatDisplay? Display { get; set; }
}

public class StatType
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;
    
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class StatDisplay
{
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class ArmorValue
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
    
    [JsonPropertyName("display")]
    public ArmorDisplay? Display { get; set; }
}

public class ArmorDisplay
{
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class WeaponInfo
{
    [JsonPropertyName("damage")]
    public WeaponDamage? Damage { get; set; }
    
    [JsonPropertyName("attack_speed")]
    public AttackSpeed? AttackSpeed { get; set; }
    
    [JsonPropertyName("dps")]
    public DPS? Dps { get; set; }
}

public class WeaponDamage
{
    [JsonPropertyName("min_value")]
    public double MinValue { get; set; }
    
    [JsonPropertyName("max_value")]
    public double MaxValue { get; set; }
    
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class AttackSpeed
{
    [JsonPropertyName("value")]
    public double Value { get; set; }
    
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class DPS
{
    [JsonPropertyName("value")]
    public double Value { get; set; }
    
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
}

public class ItemSpell
{
    [JsonPropertyName("spell")]
    public SpellReference Spell { get; set; } = new();
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}

public class SpellReference
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}

public class ItemSetInfo
{
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
    
    [JsonPropertyName("effects")]
    public List<SetEffect>? Effects { get; set; }
}

public class SetEffect
{
    [JsonPropertyName("display_string")]
    public string DisplayString { get; set; } = string.Empty;
    
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }
}

