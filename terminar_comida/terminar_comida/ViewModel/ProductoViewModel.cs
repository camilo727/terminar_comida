using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using terminar_comida.Model;
using terminar_comida.View;
using Xamarin.Forms;

namespace terminar_comida.ViewModel
{
    class ProductoViewModel
    {
        private int  variable;
        private int id;
      


        public ProductoViewModel(int variable)
        {
            this.variable = variable;
            _ = GetProducto(variable);
        }

        public List<ProductoClass> LisProducto { get ; private set; }
        public INavigation Navigation { get; }
        public Command ProductoCommand { get; }

        private int Id_producto;
       

        private async System.Threading.Tasks.Task<List<ProductoClass>> GetProducto(int variable)
        {
            this.id = variable;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://localhost:3000/api/producto/id");
            var Categoria = JsonConvert.DeserializeObject<List<ProductoClass>>(response);
            this.LisProducto = Categoria;
            return LisProducto;
        }
        public ProductoViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ProductoCommand = new Command(async () => await Navegar());

        }

        public ProductoViewModel()
        {
        }

        private async Task Navegar()
        {
            await Navigation.PushModalAsync(new VerPorductoPage(Id_producto));
        }
    }
}
