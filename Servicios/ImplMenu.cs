using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Servicios
{
    internal class ImplMenu:InterfazMenu
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a mi programa";
            Console.WriteLine("\n\t\t"+mensaje);
        }

        public int mostrarMenu()
        {
            int opcion;

            Console.WriteLine("\n\tMenú");
            Console.WriteLine("\n\t1.-Versión cliente");
            Console.WriteLine("\n\t2.-Versión empleado");
            Console.WriteLine("\n\t0.- Salir");

            opcion  = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
        public int menuEmpleado()
        {
            int opcion;

            Console.WriteLine("\n\t--Versión Empleado--");
            Console.WriteLine("\n\t1.-Validar cliente");
            Console.WriteLine("\n\t2.-Borrar cliente");
            Console.WriteLine("\n\t3.-Mostrar cliente");
            Console.WriteLine("\n\t0.-Retroceder ");

            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }

        public int menuCliente()
        {
            int opcion;

            Console.WriteLine("\n\t--Versión cliente--");
            Console.WriteLine("\n\t1.-Registro cliente");
            Console.WriteLine("\n\t2.-Acceso cliente");
            Console.WriteLine("\n\t0.- Retroceder");

            opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
