using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using terminar_comida.Model;
using terminar_comida.View;
using Xamarin.Forms;

namespace terminar_comida.ViewModel
{
   
   class CategoriaViewModel 
    {

        public INavigation Navigation { get; set; }
        public Command CategoriaCommand { get; }
        public List<CategoriaClass> listaCategoria { get; private set; }

        private string Id_categoria;

   
        public CategoriaViewModel(INavigation navigation){
            Navigation = navigation;
            CategoriaCommand = new Command(async () => await Navegar());

        }

        public CategoriaViewModel()
        {
        }

        private async Task Navegar()
        {
            await Navigation.PushModalAsync(new ProductoPage (Id_categoria));
        }

        public  void Categoria() 
        {
            _ = GetCategoria();
        }
      
        private async System.Threading.Tasks.Task<object> GetCategoria()
        {   
     
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://localhost:3000/api/categoria");
            var Categoria = JsonConvert.DeserializeObject<List<CategoriaClass>>(response);
            this.listaCategoria= Categoria;
            return listaCategoria;
        }
    }
}
