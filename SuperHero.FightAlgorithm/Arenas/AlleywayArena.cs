using System.Collections.Generic;
using SuperHero.Common;

namespace SuperHero.BattleResearch.Arenas
{
    public class AlleywayArena : IArena
    {
        public Dictionary<ArenaProperty, bool> ArenaProperties { get; } = new Dictionary<ArenaProperty, bool>();
        public string Description => "Alley";

        public AlleywayArena()
        {
            ArenaProperties.Add(ArenaProperty.IsDark, true);
            ArenaProperties.Add(ArenaProperty.IsUnderwater, false);
            ArenaProperties.Add(ArenaProperty.IsOuterSpace, false);
        }
    }
}