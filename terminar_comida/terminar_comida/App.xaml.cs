using System;
using terminar_comida.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terminar_comida
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new CategoriaPage());
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
