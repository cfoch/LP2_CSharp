using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rutina
    {
        private int _idRutina;
        private int _dni;
        private string _nombEntrenador;
        private string _descripcion;

        public Rutina(int idRutina, int dni, string nombEntrenador, string descripcion)
        {
            _idRutina = idRutina;
            _dni = dni;
            _nombEntrenador = nombEntrenador;
            _descripcion = descripcion;
        }

        public int IdRutina { get => _idRutina; set => _idRutina = value; }
        public int Dni { get => _dni; set => _dni = value; }
        public string NombEntrenador { get => _nombEntrenador; set => _nombEntrenador = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
