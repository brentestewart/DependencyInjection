using System;
using SuperHero.BattleResearch.Arenas;
using SuperHero.Common;

namespace SuperHero.BattleResearch.FightAlgorithms
{
    public class ParticipantOneWinsFightAlgorithm : IFightAlgorithm
    {
        public FightResult Fight(IHero participantOne, IHero participantTwo, IArena arena)
        {
            var randomizer = new Random();
            var scoreOne = randomizer.Next(0, 100);
            var scoreTwo = randomizer.Next(0, 100);
            return new FightResult()
            {
                ParticipantOne = participantOne,
                ParticipantTwo = participantTwo,
                Arena = arena,
                ParticipantOneScore = Math.Max(scoreOne, scoreTwo),
                ParticipantTwoScore = Math.Min(scoreOne, scoreTwo),
            };
        }
    }
}