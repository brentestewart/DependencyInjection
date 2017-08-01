using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperHero.BattleResearch.Arenas;

namespace SuperHero.Common
{
    public class FightResult
    {
        public IHero ParticipantOne { get; set; }
        public IHero ParticipantTwo { get; set; }
        public IArena Arena { get; set; }
        public Decimal ParticipantOneScore { get; set; }
        public Decimal ParticipantTwoScore { get; set; }
        public IHero Winner => ParticipantOneScore > ParticipantTwoScore ? ParticipantOne : ParticipantTwo;
    }
}
