using PropertyChanged;
using SuperHero.Common;

namespace SuperHero.Presentation
{
    [AddINotifyPropertyChangedInterface]
    public class FightResultViewModel
    {
        public FightResult FightResult { get; }

        public FightResultViewModel(FightResult fightResult)
        {
            FightResult = fightResult;
        }

        public string ParticipantOneName => FightResult.ParticipantOne.HeroName;
        public string ParticipantTwoName => FightResult.ParticipantTwo.HeroName;
        public string ArenaName => FightResult?.Arena?.Description ?? "Unknown Arena";

        public int WinnerScore => FightResult.Winner == FightResult.ParticipantOne
            ? (int)FightResult.ParticipantOneScore
            : (int)FightResult.ParticipantTwoScore;
        public int LoserScore => FightResult.Winner == FightResult.ParticipantOne
            ? (int)FightResult.ParticipantTwoScore
            : (int)FightResult.ParticipantOneScore;
        public string Results => $"{WinnerName} defeats {LoserName}";
        public string WinnerName => FightResult?.Winner?.HeroName ?? "Unknown";
        public string LoserName => WinnerName == ParticipantOneName ? ParticipantTwoName : ParticipantOneName;
        public string Score => FightResult != null ? $"{WinnerScore} to {LoserScore}" : "N/A";
    }
}