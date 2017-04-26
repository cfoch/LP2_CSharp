using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Entrenador:Empleado
    {
        private string _especialidad;
        private string _horario;
        private int _capUsuarios;
        private int _cantUsuariosDisp;

        public Entrenador(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono, tipoCargo cargo, double sueldo, TimeSpan horaInicio, TimeSpan horaFin, tipoHor tipoHorario, int cuentaBancaria,string especialidad, string horario, int capUsuarios, int cantUsuariosDisp):
            base(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono, cargo, sueldo, horaInicio, horaFin, tipoHorario, cuentaBancaria)
            
            
            
       
        {
            _especialidad = especialidad;
            _horario = horario;
            _capUsuarios = capUsuarios;
            _cantUsuariosDisp = cantUsuariosDisp;
        }

        public string Especialidad
        {
            get { return _especialidad; }
            set { _especialidad = value; }
        }

        public string Horario
        {
            get { return _horario; }
            set { _horario = value; }
        }

        public int CapUsuarios
        {
            get { return _capUsuarios; }
            set { _capUsuarios = value; }
        }

        public int CantUsuariosDisp
        {
            get { return _cantUsuariosDisp; }
            set { _cantUsuariosDisp = value; }
        }

        
    }
}
