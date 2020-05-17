using System;
using System.Collections.Generic;
using System.Text;

namespace terminar_comida.Model
{
    public class ProductoClass
    {
        public int Id_producto { get; set; }
        public string Nombre_producto { get; set; }
        public string Descripcion_producto { get; set; }
        public string Foto_producto { get; set; }
        public int Valor_producto { get; set; }
        public int Id_categoria { get; set; }
    }
}
