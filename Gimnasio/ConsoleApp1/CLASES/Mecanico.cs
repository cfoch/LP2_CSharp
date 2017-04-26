using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mecanico : Empleado
    {
        public Mecanico(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono, tipoCargo cargo, double sueldo, TimeSpan horaInicio, TimeSpan horaFin, tipoHor tipoHorario, int cuentaBancaria, string especialidad, string horario, int capUsuarios, int cantUsuariosDisp) :
         base(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono, cargo, sueldo, horaInicio, horaFin, tipoHorario, cuentaBancaria)
        {

        }
        public void revisaMaquina()
        {

        }

    }
}
