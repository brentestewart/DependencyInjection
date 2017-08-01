using SuperHero.BattleResearch.Arenas;
using SuperHero.BattleResearch.FightAlgorithms;
using SuperHero.Common;

namespace SuperHero.BattleResearch
{
    public static class Battle
    {
        public static IFightAlgorithm FightAlgorithm { get; set; } = new BasicFightAlgorithm();

        public static FightResult Fight(IHero participantOne, IHero participantTwo, IArena arena)
        {
            return FightAlgorithm.Fight(participantOne, participantTwo, arena);
        }
    }
}
