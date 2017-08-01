using SuperHero.BattleResearch.Arenas;
using SuperHero.Common;

namespace SuperHero.BattleResearch.FightAlgorithms
{
    public interface IFightAlgorithm
    {
        FightResult Fight(IHero participantOne, IHero participantTwo, IArena arena);
    }
}