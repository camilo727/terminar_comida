using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using terminar_comida.Model;
using terminar_comida.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terminar_comida.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriaPage : ContentPage
    {
        public CategoriaPage()
        {
            InitializeComponent();
            BindingContext = new CategoriaViewModel(Navigation);
        }
        
    }
}