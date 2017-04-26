using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CLASES
{
    class Curso
    {
        private int _idCurso;
        private int _dniEntrenador;
        private string _nombre;
        private string _descripcion;
        private int _capacidad;
        private int _vacantes;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private int _duracion;
        private string _disponibilidad;

        public Curso(int idCurso, int dniEntrenador, string nombre, string descripcion, int capacidad, int vacantes, DateTime fechaInicio, DateTime fechaFin, int duracion, string disponibilidad)
        {
            _idCurso = idCurso;
            _dniEntrenador = dniEntrenador;
            _nombre = nombre;
            _descripcion = descripcion;
            _capacidad = capacidad;
            _vacantes = vacantes;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            _duracion = duracion;
            _disponibilidad = disponibilidad;
        }

        public int IdCurso { get => _idCurso; set => _idCurso = value; }
        public int DniEntrenador { get => _dniEntrenador; set => _dniEntrenador = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public int Vacantes { get => _vacantes; set => _vacantes = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
        public int Duracion { get => _duracion; set => _duracion = value; }
        public string Disponibilidad { get => _disponibilidad; set => _disponibilidad = value; }
    }
}
