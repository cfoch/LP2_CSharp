using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Administrador : Empleado
    {
        public Administrador(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono, tipoCargo cargo, double sueldo, TimeSpan horaInicio, TimeSpan horaFin, tipoHor tipoHorario, int cuentaBancaria):
            base(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono, cargo, sueldo, horaInicio, horaFin, tipoHorario, cuentaBancaria)
        {

        }
        public Cliente crearCliente(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono,int correlativo)
        {
            Cliente c = new Cliente(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono,correlativo);
            return c;
        }
        public Empleado crearEmpleado(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono, int correlativo, tipoCargo cargo, double sueldo, TimeSpan horaInicio, TimeSpan horaFin, tipoHor tipoHorario, int cuentaBancaria)
        {
            Empleado emp = new Empleado(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono, cargo, sueldo, horaInicio, horaFin, tipoHorario, cuentaBancaria);
            return emp;
        }
        public void mantenerServicios()
        {

        }

        public void mantenerRutinas()
        {

        }

        public void modificarJerarquia()
        {

        }
        public void crearReporteVentas()
        {

        }
        public void crearReporteInventario()
        {

        }
        public void crearReporteClientes()
        {

        }
    }
}
