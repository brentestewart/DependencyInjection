using System.Collections.Generic;
using SuperHero.Common;

namespace SuperHero.BattleResearch.Arenas
{
    public interface IArena
    {
        string Description { get; }
        Dictionary<ArenaProperty, bool> ArenaProperties { get; }
    }
}
