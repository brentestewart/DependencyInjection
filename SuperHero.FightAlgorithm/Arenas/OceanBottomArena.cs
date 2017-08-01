using System.Collections.Generic;
using SuperHero.Common;

namespace SuperHero.BattleResearch.Arenas
{
    public class OceanBottomArena : IArena
    {
        public Dictionary<ArenaProperty, bool> ArenaProperties { get; } = new Dictionary<ArenaProperty, bool>();
        public string Description => "Ocean Trench";

        public OceanBottomArena()
        {
            ArenaProperties.Add(ArenaProperty.IsDark, false);
            ArenaProperties.Add(ArenaProperty.IsUnderwater, true);
            ArenaProperties.Add(ArenaProperty.IsOuterSpace, false);
        }
    }
}