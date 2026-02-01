﻿using JulianWow.Models;

namespace JulianWow.Agents;

public interface IBattleNetAgent
{
    Task<WowCharacter> GetCharacter(string realmSlug, string characterName);
    Task<WowCharacterStats> GetCharacterStats(string realmSlug, string characterName);
    Task<WowEquipment> GetCharacterEquipment(string realmSlug, string characterName);
}