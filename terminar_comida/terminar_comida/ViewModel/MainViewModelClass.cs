using System;
using System.Collections.Generic;
using System.Text;
using terminar_comida.Model;
using Xamarin.Forms;

namespace terminar_comida.ViewModel
{
    class MainViewModelClass : ContentPage
    {
       
        public CategoriaViewModel Categoria { get;set; }
        public ProductoViewModel Prducto { get; set; }
        public VerProductoViewModel VerProducto { get; set; }
        public MainViewModelClass ()
        {
            Categoria = new CategoriaViewModel();
            Prducto = new ProductoViewModel();
           this.VerProducto = new VerProductoViewModel();

        }

     
    }

}
