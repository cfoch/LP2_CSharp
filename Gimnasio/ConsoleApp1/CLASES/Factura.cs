using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Factura
    {
        private int _dni;
        private int _idFactura;
        private double _subTotal;
        private double _igv;
        private int _ruc;

        public Factura(int dni, int idFactura, double subTotal, double igv, int ruc)
        {
            _dni = dni;
            _idFactura = idFactura;
            _subTotal = subTotal;
            _igv = igv;
            _ruc = ruc;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public int IdFactura { get => _idFactura; set => _idFactura = value; }
        public double SubTotal { get => _subTotal; set => _subTotal = value; }
        public double Igv { get => _igv; set => _igv = value; }
        public int Ruc { get => _ruc; set => _ruc = value; }
    }
}
