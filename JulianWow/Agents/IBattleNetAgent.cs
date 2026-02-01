using JulianWow.Models;

namespace JulianWow.Agents;

public interface IBattleNetAgent
{
    Task<WowCharacter> GetDruidCharacter();
    Task<WowCharacterStats> GetDruidStats();
    Task<WowEquipment> GetDruidEquipment();
}