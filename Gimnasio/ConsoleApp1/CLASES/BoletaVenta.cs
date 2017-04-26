using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BoletaVenta
    {
        private int _dni;
        private int _idBoleta;
        private int _idCliente;
        private double _total;

        public BoletaVenta(int dni, int idBoleta, int idCliente, double total)
        {
            _dni = dni;
            _idBoleta = idBoleta;
            _idCliente = idCliente;
            _total = total;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public int IdBoleta { get => _idBoleta; set => _idBoleta = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public double Total { get => _total; set => _total = value; }
    }
}
