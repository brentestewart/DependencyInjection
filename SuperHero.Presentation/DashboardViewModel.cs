using SuperHero.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using PropertyChanged;
using SuperHero.BattleResearch;
using SuperHero.BattleResearch.Arenas;
using SuperHero.Repository;

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

    [AddINotifyPropertyChangedInterface]
    public class DashboardViewModel
    {
        public ObservableCollection<IHero> AvailableHeroes { get; set; } = new ObservableCollection<IHero>();
        public IHero ParticipantOne { get; set; }
        public IHero ParticipantTwo { get; set; }
        public DelegateCommand FightCommand { get; set; }
        public FightResultViewModel LastResult { get; set; }
        public ObservableCollection<IArena> AllArenas { get; set; } = new ObservableCollection<IArena>();
        public IArena SelectedArena { get; set; }
        public bool HaveResults { get; set; }
        private IHeroRepository HeroRepository { get; set; }

        public DashboardViewModel(IHeroRepository heroRepository)
        {
            HeroRepository = heroRepository;
            FightCommand = new DelegateCommand(Fight);
            LoadArenas();
            LoadHeroes();
        }

        private void LoadArenas()
        {
            Arenas.GetArenas().ForEach(a => AllArenas.Add(a));
            SelectedArena = AllArenas.First();
        }

        private void Fight()
        {
            LastResult = new FightResultViewModel(Battle.Fight(ParticipantOne, ParticipantTwo, SelectedArena));
            HaveResults = true;
        }

        private void LoadHeroes()
        {
            HeroRepository.GetAllHeroes().ForEach(h => AvailableHeroes.Add(h));
        }
    }
}
