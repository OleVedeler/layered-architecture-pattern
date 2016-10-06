using System.Windows;
using TheShop.Business.ViewModels;

namespace TheShopper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {            
            this.DataContext = (App.Current as App).DependencyInversionContainer.GetInstance<MainWindowViewModel>();
        }
    }
}
