using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Servicios
{
    internal interface InterfazMenu
    {
        public void mensajeBienvenida();

        public int mostrarMenu();

        public int menuEmpleado();

        public int menuCliente();
    }
}
