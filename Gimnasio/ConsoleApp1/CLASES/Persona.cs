using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        private int _dni;
        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;
        private string _direccion;
        private string _email;
        private string _distrito;
        private DateTime _fechaNac;
        private int _telefono;

        public Persona(int dni, string nombre, string apellidoPaterno, string apellidoMaterno, string direccion, string email, string distrito, DateTime fechaNac, int telefono)
        {
            Dni = dni;
            Nombre = nombre;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            Direccion = direccion;
            Email = email;
            Distrito = distrito;
            FechaNac = fechaNac;
            Telefono = telefono;
        }

        public int Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
        public string ApellidoMaterno { get => _apellidoMaterno; set => _apellidoMaterno = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public string Distrito { get => _distrito; set => _distrito = value; }
        public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public int Telefono { get => _telefono; set => _telefono = value; }
    }
}
