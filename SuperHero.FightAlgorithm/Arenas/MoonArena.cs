using System.Collections.Generic;
using SuperHero.Common;

namespace SuperHero.BattleResearch.Arenas
{
    public class MoonArena : IArena
    {
        public Dictionary<ArenaProperty, bool> ArenaProperties { get; } = new Dictionary<ArenaProperty, bool>();
        public string Description => "Moon Crater";

        public MoonArena()
        {
            ArenaProperties.Add(ArenaProperty.IsDark, false);
            ArenaProperties.Add(ArenaProperty.IsUnderwater, false);
            ArenaProperties.Add(ArenaProperty.IsOuterSpace, true);
        }
    }
}