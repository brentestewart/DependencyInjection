using System.Windows;
using SuperHero.Presentation;

namespace SuperHero.View
{
    /// <summary>
    /// Interaction logic for DashboardView.xaml
    /// </summary>
    public partial class DashboardView : Window
    {
        public DashboardViewModel ViewModel { get; set; }

        public DashboardView()
        {
            InitializeComponent();
            DataContext = ViewModel = new DashboardViewModel();
        }
    }
}
