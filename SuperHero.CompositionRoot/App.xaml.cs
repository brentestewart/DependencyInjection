using System.Windows;
using Ninject;
using Ninject.Extensions.Factory;
using SuperHero.Common;
using SuperHero.Data;
using SuperHero.Data.Factories;
using SuperHero.Data.StaticServices;
using SuperHero.Repository;
using SuperHero.View;

namespace SuperHero.CompositionRoot
{
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
            //Battle.FightAlgorithm = new PaticipantTwoWinsFightAlgorithm();
        }

        private void SetupContainer()
        {
            Container = new StandardKernel();
            Container.Bind<IHero>().To<Hero>();
            Container.Bind<IHeroRepository>().To<HeroRepository>();
            Container.Bind<IHeroFactory>().ToFactory();
            Container.Bind<IHeroDataService>().To<AllHeroStaticDataService>().InSingletonScope();
            Container.Bind<IWeapon>().To<Unarmed>().InSingletonScope();
            Container.Bind<IAttack>().To<Punch>().InSingletonScope();

            var heroFactory = Container.Get<IHeroFactory>();
            HeroServiceLocator.Register<IHeroFactory>(() => heroFactory);
        }
    }
}
