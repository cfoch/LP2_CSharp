using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MembresiaXCliente
    {
        private int _dni;
        private int _idMembresia;
        private DateTime _fechaInicioMemb;
        private DateTime _fechaFinMemb;
        private int _frezzRestante;
        private DateTime _fechaInicioFreez;
        private DateTime _fechaFinFreez;

        public MembresiaXCliente(int dni, int idMembresia, DateTime fechaInicioMemb, DateTime fechaFinMemb, int frezzRestante, DateTime fechaInicioFreez, DateTime fechaFinFreez)
        {
            _dni = dni;
            _idMembresia = idMembresia;
            _fechaInicioMemb = fechaInicioMemb;
            _fechaFinMemb = fechaFinMemb;
            _frezzRestante = frezzRestante;
            _fechaInicioFreez = fechaInicioFreez;
            _fechaFinFreez = fechaFinFreez;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public int IdMembresia { get => _idMembresia; set => _idMembresia = value; }
        public DateTime FechaInicioMemb { get => _fechaInicioMemb; set => _fechaInicioMemb = value; }
        public DateTime FechaFinMemb { get => _fechaFinMemb; set => _fechaFinMemb = value; }
        public int FrezzRestante { get => _frezzRestante; set => _frezzRestante = value; }
        public DateTime FechaInicioFreez { get => _fechaInicioFreez; set => _fechaInicioFreez = value; }
        public DateTime FechaFinFreez { get => _fechaFinFreez; set => _fechaFinFreez = value; }
    }
}
