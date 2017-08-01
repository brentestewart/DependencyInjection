using System.Collections.Generic;

namespace SuperHero.BattleResearch.Arenas
{
    public static class Arenas
    {
        public static IArena ParkingLotArena => new ParkingLotArena();
        public static IArena AlleywayArena => new AlleywayArena();
        public static IArena OceanBottomArena => new OceanBottomArena();
        public static IArena MoonArena => new MoonArena();

        public static List<IArena> GetArenas()
        {
            return new List<IArena>
            {
                ParkingLotArena,
                AlleywayArena,
                OceanBottomArena,
                MoonArena
            };
        }
    }
}