using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Ninject;
using Ninject.Extensions.Factory;
using SuperHero.BattleResearch;
using SuperHero.BattleResearch.FightAlgorithms;
using SuperHero.Common;
using SuperHero.Data;
using SuperHero.Data.Factories;
using SuperHero.Repository;
using SuperHero.View;

namespace SuperHero.CompositionRoot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IKernel Container { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            SetupContainer();

            SetupFights();
            this.MainWindow = Container.Get<DashboardView>();
            this.MainWindow.Show();
        }

        private void SetupFights()
        {
            //Inject the fight algorithm
            //FightArena.FightAlgorithm = Algorithms.SimpleParticipantOneWins;
            //Battle.FightAlgorithm = new PaticipantTwoWinsFightAlgorithm();
        }

        private void SetupContainer()
        {
            Container = new StandardKernel();
            Container.Bind<IHero>().To<Hero>();
            Container.Bind<IHeroRepository>().To<DCHeroRepository>();
            Container.Bind<IHeroFactory>().ToFactory();
            Container.Bind<IHeroDataService>().To<DCHeroJsonDataService>().InSingletonScope();
            Container.Bind<IWeapon>().To<BowAndArrow>().InSingletonScope();
            Container.Bind<IAttack>().To<Shoot>().InSingletonScope();

            var heroDataService = Container.Get<IHeroDataService>();
            HeroServiceLocator.Register<IHeroDataService>(() => heroDataService);
        }
    }
}
