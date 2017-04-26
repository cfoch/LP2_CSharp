using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace ConsoleApp1
{
    public class Cliente:Persona
    {
        private int _idMembresia;
        private BindingList<Rutina> _rutinas;

        public Cliente(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono,int idMembresia):
            base(dni, nombre, apellidoPaterno, apellidoMaterno, direccion, email, distrito, fechaNac, telefono)
        {
            IdMembresia = idMembresia;
            _rutinas = new BindingList<Rutina>();
        }

        public int IdMembresia { get => _idMembresia; set => _idMembresia = value; }
    }
}
