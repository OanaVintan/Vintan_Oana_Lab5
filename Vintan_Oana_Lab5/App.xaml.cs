using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Vintan_Oana_Lab5.Data;
using System.IO;

namespace Vintan_Oana_Lab5
{
    public partial class App : Application
    {
        static AgendaDatabase database;
        public static AgendaDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new
                   AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                   LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AgendaPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
