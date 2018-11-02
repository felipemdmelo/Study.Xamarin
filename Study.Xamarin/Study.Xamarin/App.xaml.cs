using SQLite;
using Study.Xamarin.Data;
using Study.Xamarin.Entities;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Study.Xamarin
{
    public partial class App : Application
    {

        static SQLiteConnection _bd;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static SQLiteConnection BD
        {
            get {
                if (_bd == null) {
                    string path = DependencyService.Get<IDatabasePath>().GetPath();
                    _bd = new SQLiteConnection(path);
                    _bd.CreateTable<Contato>();
                }

                return _bd;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
