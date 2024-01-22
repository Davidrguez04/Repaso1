/*Arquitectura vista en clase. Mínimo tres servicios, uno que controles los diferentes menú; otro que controle 
 * la funcionalidad de empleado y otro que controle la funcionalidad cliente.


Crea una aplicación cuya interacción con el usuario sea por consola. La aplicación tendrá dos versiones a las 
cuales se accederán desde un menú inicial:
Versión empleado
Versión cliente
Dentro de la versión empleado existirán las siguientes opciones:
Validar cliente
Borrado de cliente
Mostrar cliente
Dentro de la versión cliente existirán las siguientes opciones:
Registro cliente
Acceso cliente (Login)
El flujo de la aplicación será el siguiente:
Un cliente accede a la versión cliente y se registra. Una vez registrado el cliente, un empleado accede a la 
versión empleado y valida el cliente. Una vez validado el cliente, el cliente accede a la versión cliente y 
accede con su usuario y contraseña (login).
Un empleado, al acceder a la versión empleado, también podrá borrar un cliente por su DNI o mostrar todos los 
clientes.

Particularidades:
Registro cliente
Al cliente se le solicitará la información dni, nombre completo (con espacio por separación y formato: 
nombre apellido1 y apellido2), email y contraseña. 
A partir del nombre completo se obtendrán los campos nombre, apellido1 y apellido2.
El campo esValidado se iniciará con valor false.
El id lo informará la aplicación, y no podrá repetirse con  un id que ya exista.
Acceso cliente
Se solicitará email y contraseña, si ambos campos se informan correctamente se mostrará un mensaje: "INICIO 
DE SESIÓN CORRECTO".
No podrá acceder ningún cliente que no esté validado.
Validar cliente
Al acceder a esta funcionalidad, aparecerá un listado con los clientes que aún no están validados (los que tienen 
el campo esValidado a false).
En el listado se verán los siguientes campos: dni y nombre completo.
Mediante el dni, el empleado podrá indicar qué usuario validar. En el empleado indicado por el dni se cambiará el
valor false por true de forma automática.
Entre cliente y cliente habrá una separación que siga el siguiente formato: "\\\\\\\\\\"
La información de cada cliente aparecerá separada en dos líneas siguiendo el siguiente formato:
\\\\\\\\\\
DNI: 123456678P
NOMBRE: Pedro García García
\\\\\\\\\\
Borrar cliente
Se solicitará el dni del cliente que se quiere borrar
Mostrar clientes
Se muestra un listado con todos los clientes y la siguiente información de cada uno de ellos: dni, nombre 
completo y si está validado.
El nombre completo, solo para esta funcionalidad, tendrá el formato: "apellido1 apellido2, nombre"
Entre cliente y cliente habrá una separación que siga el siguiente formato: "%%%%%%%%%%"
La información de cada cliente aparecerá separada en tres líneas siguiendo el siguiente formato:
%%%%%%%%%%
DNI: 123456678P
NOMBRE: García García, Pedro
ESTADO VALIDACIÓN: si o no
%%%%%%%%%%

CADA VEZ QUE SE HAYA FINALIZADO UNA FUNCIONALIDAD DE CLIENTE O EMPLEADO SE MOSTRARÁ EL MENÚ INICIAL PARA ELEGIR
EN QUÉ VERSIÓN ENTRAR A LA APLICACIÓN. CADA FUNCIONALIDAD EN SÍ MISMA NO SERÁ ITERATIVA.

El cliente tendrá la siguiente información:
idCliente
dniCliente
nombreCliente
apellido1Cliente
apellido2Cliente
nombreCompletoCliente
emailCliente
contraseniaCliente
esValidado*/

using Repaso1.Dto;
using Repaso1.Servicios;

namespace Repaso1.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazMenu ni = new ImplMenu();
            InterfazAltaC mi=new ImplAltaCliente();
            InterfazFunciones si=new ImplFunciones();

            ClienteDto cliente= new ClienteDto();
            List<ClienteDto>listaClientes= new List<ClienteDto>();

            ni.mensajeBienvenida();

            bool salir=false;
            int opcionSelec;
            

            while(!salir)
            {
                opcionSelec = ni.mostrarMenu();
                Console.WriteLine("\n\t\tHas seleccionado la opción " + opcionSelec);

                switch(opcionSelec)
                {
                    case 0:
                        salir = true;
                        break;

                    case 1:
                        while(!salir)
                        {
                            
                        opcionSelec=ni.menuCliente();
                        Console.WriteLine("\n\tHas seleccionado la opción " + opcionSelec);
                        
                            switch (opcionSelec)
                            {
                                case 0:
                                    salir = true;
                                    break;

                                case 1:
                                    Console.Clear();
                                    mi.darAltaCliente(listaClientes);
                                    break;

                                case 2:
                                    Console.Clear();
                                    mi.accesoCliente(listaClientes);
                                    
                                    break;

                                default:
                                    Console.WriteLine("\n\t¡¡ Opción seleccionada incorrecta !!");
                                    break;

                            }
                        }
                        salir = false;
                        
                        break;

                    case 2:

                        while (!salir)
                        {
                            
                            opcionSelec=ni.menuEmpleado();
                            Console.WriteLine("\n\tHas seleccionado la opción " + opcionSelec);

                            switch (opcionSelec)
                            {

                                case 0:
                                    salir = true;
                                    break;

                                case 1:
                                    Console.Clear();
                                    si.validarCliente(listaClientes);
                                    
                                    break;

                                case 2:
                                    si.borrarCliente(listaClientes);
                                    break;

                                case 3:
                                    Console.Clear();
                                    si.mostrarClientes(listaClientes);
                                    break;

                                default:
                                    Console.WriteLine("\n\t!! Opción seleccionada incorrecta ¡¡");
                                    break;
                            }


                        }
                        salir=false;

                        break;
                   

                    default:
                        Console.WriteLine("\n\t¡¡¡ Opción seleccionada incorrecta !!!");
                        break;
                }

            } 

            Console.WriteLine("\n\n\tPulse una tecla para salir: ");
            Console.ReadKey();
        }
    }
}
