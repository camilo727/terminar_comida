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
    public partial class VerPorductoPage : ContentPage
    {
        public VerPorductoPage()
        {
           
        }
        public VerPorductoPage(int Id_producto)
        {

            int variable = Id_producto;


            BindingContext = new VerProductoViewModel(variable);
        }


    }
}