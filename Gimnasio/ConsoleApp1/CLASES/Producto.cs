using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CLASES
{
    public class Producto
    {
        private int _idProducto;
        private string _nombreProducto;
        private string _descripcion;
        private int _stock;
        private float _precio;

        public Producto()
        {

        }

        public Producto(int idProducto, string nombreProducto, string descripcion, int stock, float precio)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _descripcion = descripcion;
            _stock = stock;
            _precio = precio;
        }

        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public string NombreProducto { get => _nombreProducto; set => _nombreProducto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public float Precio { get => _precio; set => _precio = value; }
    }
}
