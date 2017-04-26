using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Membresia
    {
        private int _idMembresia;
        private string _nMembresia;
        private string _descripcion;
        private int _diasFreezing;
        private int _diasMembresia;

        public Membresia(int idMembresia, string nMembresia, string descripcion, int diasFreezing, int diasMembresia)
        {
            _idMembresia = idMembresia;
            _nMembresia = nMembresia;
            _descripcion = descripcion;
            _diasFreezing = diasFreezing;
            _diasMembresia = diasMembresia;
        }

        public int IdMembresia { get => _idMembresia; set => _idMembresia = value; }
        public string NMembresia { get => _nMembresia; set => _nMembresia = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int DiasFreezing { get => _diasFreezing; set => _diasFreezing = value; }
        public int DiasMembresia { get => _diasMembresia; set => _diasMembresia = value; }


    }
}
