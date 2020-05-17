using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using terminar_comida.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace terminar_comida.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoPage : ContentPage
    {
        public ProductoPage()
        {
           
            BindingContext = new CategoriaViewModel(Navigation);
        }

        
        public ProductoPage(string id_categoria)
        {

            int variable = Int32.Parse(id_categoria);

           
            BindingContext = new ProductoViewModel(variable);
        }
    }
}