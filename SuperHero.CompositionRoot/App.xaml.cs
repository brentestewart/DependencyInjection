using System.Windows;
using Ninject;
using SuperHero.View;

namespace SuperHero.CompositionRoot
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            SetupFights();

            this.MainWindow = new DashboardView();
            this.MainWindow.Show();
        }

        private void SetupFights()
        {
            //Inject the fight algorithm
            //Battle.FightAlgorithm = new PaticipantTwoWinsFightAlgorithm();
        }
    }
}
