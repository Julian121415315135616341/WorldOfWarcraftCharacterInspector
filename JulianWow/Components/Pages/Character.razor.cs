using JulianWow.Agents;
using JulianWow.Models;
using Microsoft.AspNetCore.Components;

namespace JulianWow.Components.Pages;

public partial class Character
{
    [Inject]
    public IBattleNetAgent BattleNetAgent { get; set; } = null!;
    
    [Parameter]
    public string? RealmSlug { get; set; }
    
    [Parameter]
    public string? CharacterName { get; set; }
    
    private WowCharacter? _character;
    private WowCharacterStats? _stats;
    private WowEquipment? _equipment;
    private bool _isLoading = true;
    private string? _error;

    protected async override Task OnInitializedAsync()
    {
        await LoadCharacter();
    }

    protected override async Task OnParametersSetAsync()
    {
        await LoadCharacter();
    }

    private async Task LoadCharacter()
    {
        if (string.IsNullOrWhiteSpace(RealmSlug) || string.IsNullOrWhiteSpace(CharacterName))
        {
            _error = "Realm and character name are required.";
            _isLoading = false;
            return;
        }

        _isLoading = true;
        _error = null;

        try
        {
            _character = await BattleNetAgent.GetCharacter(RealmSlug, CharacterName);
            _stats = await BattleNetAgent.GetCharacterStats(RealmSlug, CharacterName);
            _equipment = await BattleNetAgent.GetCharacterEquipment(RealmSlug, CharacterName);
        }
        catch (Exception ex)
        {
            _error = $"Failed to load character: {ex.Message}";
        }
        finally
        {
            _isLoading = false;
        }
    }

    private string GetFactionClass()
    {
        if (_character == null) return "";
        
        return _character.Faction.Type switch
        {
            "ALLIANCE" => "alliance",
            "HORDE" => "horde",
            _ => ""
        };
    }
    
    private int GetSlotOrder(string slotType)
    {
        return slotType switch
        {
            "HEAD" => 1,
            "NECK" => 2,
            "SHOULDER" => 3,
            "BACK" => 4,
            "CHEST" => 5,
            "WRIST" => 6,
            "HANDS" => 7,
            "WAIST" => 8,
            "LEGS" => 9,
            "FEET" => 10,
            "FINGER_1" => 11,
            "FINGER_2" => 12,
            "TRINKET_1" => 13,
            "TRINKET_2" => 14,
            "MAIN_HAND" => 15,
            "OFF_HAND" => 16,
            _ => 99
        };
    }
    
    private string GetStatIcon(string statType)
    {
        return statType switch
        {
            "INTELLECT" => "🧠",
            "STAMINA" => "❤️",
            "STRENGTH" => "💪",
            "AGILITY" => "🏃",
            "HASTE_RATING" => "⚡",
            "CRIT_RATING" => "💥",
            "MASTERY_RATING" => "🎯",
            "VERSATILITY" => "🔄",
            "COMBAT_RATING_SPEED" => "💨",
            _ => "+"
        };
    }
}

