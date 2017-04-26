using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace ConsoleApp1
{
    public class Empresa
    {
        private string _nombre;
        private string _direccion;
        private int _ruc;
        private BindingList<Cliente> clientela;
        private BindingList<Empleado> empleados;
    }
}
