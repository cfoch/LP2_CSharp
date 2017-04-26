using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductoXCliente
    {
        private int _dni;
        private int _idProducto;
        private DateTime _fechaCompra;
        private int _cantAdq;

        public ProductoXCliente(int dni, int idProducto, DateTime fechaCompra, int cantAdq)
        {
            _dni = dni;
            _idProducto = idProducto;
            _fechaCompra = fechaCompra;
            _cantAdq = cantAdq;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public int IdProducto { get => _idProducto; set => _idProducto = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public int CantAdq { get => _cantAdq; set => _cantAdq = value; }
    }
}
