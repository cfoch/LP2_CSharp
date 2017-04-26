using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum tipoCargo { Administrador, Mecanico, Entrenador };
    public enum tipoHor { Manana, Tarde, Noche };
    public class Empleado : Persona
    {


        private tipoCargo _cargo;
        private Double _sueldo;
        private TimeSpan _horaInicio;
        private TimeSpan _horaFin;
        private tipoHor _tipoHorario;
        private int _cuentaBancaria;

        public Empleado(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono, tipoCargo cargo, double sueldo, TimeSpan horaInicio, TimeSpan horaFin, tipoHor tipoHorario, int cuentaBancaria) :
            base(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono)

        {
            _cargo = cargo;
            _sueldo = sueldo;
            _horaInicio = horaInicio;
            _horaFin = horaFin;
            _tipoHorario = tipoHorario;
            _cuentaBancaria = cuentaBancaria;
        }

        public Double Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }


        public TimeSpan HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; }
        }


        public TimeSpan HoraFin
        {
            get { return _horaFin; }
            set { _horaFin = value; }
        }


        public tipoHor TipoHorario
        {
            get { return _tipoHorario; }
            set { _tipoHorario = value; }
        }


        public tipoCargo Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }


        public int CuentaBancaria
        {
            get { return _cuentaBancaria; }
            set { _cuentaBancaria = value; }
        }



    }
}
