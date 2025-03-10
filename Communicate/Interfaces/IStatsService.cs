﻿using Data.Structures.Creature;
using Data.Structures.Player;

namespace Communicate.Interfaces
{
    public interface IStatsService : IComponent
    {
        void Init();
        CreatureBaseStats InitStats(Creature creature);
        CreatureBaseStats GetBaseStats(Player player);
        void UpdateStats(Creature creature);
    }
}
