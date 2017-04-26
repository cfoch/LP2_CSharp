using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Servicio
    {
        private int _idServicio;
        private string _nServicio;
        private string _descripcion;
        private bool _disponibilidad;

        public Servicio(int idServicio, string nServicio, string descripcion, bool disponibilidad)
        {
            _idServicio = idServicio;
            _nServicio = nServicio;
            _descripcion = descripcion;
            _disponibilidad = disponibilidad;
        }

        public int IdServicio { get => _idServicio; set => _idServicio = value; }
        public string NServicio { get => _nServicio; set => _nServicio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Disponibilidad { get => _disponibilidad; set => _disponibilidad = value; }
    }
}
