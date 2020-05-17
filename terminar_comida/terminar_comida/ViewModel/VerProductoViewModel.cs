using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using terminar_comida.Model;

namespace terminar_comida.ViewModel
{
    class VerProductoViewModel
    {
        private int variable;
        private int id;
        private string id_usuario;
        private string id_producto;

        public ICommand ProductoCommand => new RelayCommand(VerProducto);
        public async void VerProducto()
        {
            int Id_usu = Int32.Parse(id_usuario);
            int Id_pro = Int32.Parse(id_producto);
            HttpClient client = new HttpClient();
            PedidoClass agregar = new PedidoClass();
            agregar.Id_producto = Id_pro;
            agregar.Id_usuario = Id_usu;


            String jsonAgre = JsonConvert.SerializeObject(agregar);
            var content = new StringContent(jsonAgre, Encoding.UTF8, "application/json");
            string url = "http://localhost:3000/api/pedido/agregar";
            var imprime = await client.PostAsync(url, content);
            var json = JsonConvert.SerializeObject(imprime);
        }

        public VerProductoViewModel(int variable)
        {
            this.variable = variable;
            _ = GetVerproducto(variable);
        }

        public List<ProductoClass> LisProducto { get; private set; }

        private async System.Threading.Tasks.Task<List<ProductoClass>> GetVerproducto(int variable)
        {
            this.id = variable;
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync("http://localhost:3000/api/producto/ver/id");
            var Categoria = JsonConvert.DeserializeObject<List<ProductoClass>>(response);
            this.LisProducto = Categoria;
            return LisProducto;
        }

    }
}
