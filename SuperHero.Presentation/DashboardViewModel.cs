using SuperHero.Common;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Commands;
using PropertyChanged;
using SuperHero.BattleResearch;
using SuperHero.BattleResearch.Arenas;

namespace SuperHero.Presentation
{
    [AddINotifyPropertyChangedInterface]
    public class DashboardViewModel
    {
        private IHeroRepository HeroRepository { get; set; }
        public ObservableCollection<IHero> AvailableHeroes { get; set; } = new ObservableCollection<IHero>();
        public ObservableCollection<IArena> AllArenas { get; set; } = new ObservableCollection<IArena>();
        public IHero ParticipantOne { get; set; }
        public IHero ParticipantTwo { get; set; }
        public FightResultViewModel LastResult { get; set; }
        public IArena SelectedArena { get; set; }
        public bool HaveResults { get; set; }
        public DelegateCommand FightCommand { get; set; }

        public DashboardViewModel(IHeroRepository heroRepository)
        {
            HeroRepository = heroRepository;
            FightCommand = new DelegateCommand(Fight);

            LoadArenas();
            LoadHeroes();
        }

        private void Fight()
        {
            LastResult = new FightResultViewModel(Battle.Fight(ParticipantOne, ParticipantTwo, SelectedArena));
            HaveResults = true;
        }

        private void LoadArenas()
        {
            Arenas.GetArenas().ForEach(a => AllArenas.Add(a));
            SelectedArena = AllArenas.First();
        }

        private void LoadHeroes()
        {
            HeroRepository.GetAllHeroes().ForEach(h => AvailableHeroes.Add(h));
        }
    }
}
