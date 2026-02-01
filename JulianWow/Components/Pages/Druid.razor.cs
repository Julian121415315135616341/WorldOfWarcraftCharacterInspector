using JulianWow.Agents;
using JulianWow.Models;
using Microsoft.AspNetCore.Components;

namespace JulianWow.Components.Pages;

public partial class Druid
{
    [Inject]
    public IBattleNetAgent BattleNetAgent { get; set; } = null!;
    
    
    private WowCharacter? _character;
    private WowCharacterStats? _stats;
    private WowEquipment? _equipment;
    private bool _isLoading = true;

    protected async override Task OnInitializedAsync()
    {
        _character = await BattleNetAgent.GetDruidCharacter();
        _stats = await BattleNetAgent.GetDruidStats();
        _equipment = await BattleNetAgent.GetDruidEquipment();
        _isLoading = false;
    }
}