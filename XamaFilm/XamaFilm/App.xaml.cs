using System;
using System.Threading.Tasks;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using XamaFilm.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamaFilm
{
	public partial class App : Application
	{
		public App ()
		{
            LiveReload.Init();

			InitializeComponent();


            InicializeNavigator();
            //MainPage = new MasterView();
            //MainPage = new LoginView();
            //MainPage = new SettingsView();
            //MainPage = new HomeView();
            //MainPage = new DetailMovieView();
            //MainPage = new DetailSerieView();
            //MainPage = new DetailEpisodeView();
            //MainPage = new AcknowledgeView();
            //MainPage = new DetailSeasonSerieView();

        }

        private void InicializeNavigator()
        {
            ViewModelLocator.Instance.Resolve<INavigationService>().InitializeAsync();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
