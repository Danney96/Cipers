using Entiteter;
using Försök3.ViewModel;
using System.Windows;
using Försök3.Services;
using Försök3.Views;

namespace Försök3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Startup += (s, e) =>
            {

                WindowService.RegisterWindow<AnnonsWindowViewModel, AnnonsWindow>();


            };
        }
    }
}
