using StructureMap;
using System.Windows;
using TheShopper.InversionOfControl;

namespace TheShopper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Container DependencyInversionContainer;


        public App()
        {
            DependencyInversionContainer = new Container(new RuntimeRegistry());
        }
    }
}
