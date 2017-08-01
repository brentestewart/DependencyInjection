using System;
using SuperHero.BattleResearch.Arenas;
using SuperHero.Common;

namespace SuperHero.BattleResearch.FightAlgorithms
{
    public class BasicFightAlgorithm : IFightAlgorithm
    {
        public FightResult Fight(IHero participantOne, IHero participantTwo, IArena arena)
        {
            var randomizer = new Random();
            var oddMultiplierOne = ((Decimal)randomizer.Next(1, 100)) / 100;
            var oddMultiplierTwo = ((Decimal)randomizer.Next(1, 100)) / 100;
            var participantOneScore = (participantOne.Health + participantOne.Defense) * oddMultiplierOne;
            var participantTwoScore = (participantTwo.Health + participantTwo.Defense) * oddMultiplierTwo;

            return new FightResult()
            {
                ParticipantOne = participantOne,
                ParticipantTwo = participantTwo,
                Arena = arena,
                ParticipantOneScore = participantOneScore,
                ParticipantTwoScore = participantTwoScore
            };
        }
    }
}