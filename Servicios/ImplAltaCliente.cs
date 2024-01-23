using Repaso1.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Servicios
{
    internal class ImplAltaCliente:InterfazAltaC
    {
        public void darAltaCliente(List<ClienteDto>listaClientes)
        {
            ClienteDto cliente= datosCliente();

            int contador=1;
            foreach (ClienteDto clienteDto in listaClientes)
            {
               
                 cliente.IdCliente=contador;
                contador++;
            }

            listaClientes.Add(cliente);
            contador++;
        }

        private ClienteDto datosCliente()
        {
            ClienteDto cliente=new ClienteDto();
            
        Console.Write("\n\tIntroduzca su dni: ");
            cliente.DniCliente = Console.ReadLine();

            

            Console.Write("\n\tIntroduzca su nombre completo: ");
            cliente.NombreCompletoCliente = Console.ReadLine();

            string[] palabras = cliente.NombreCompletoCliente.Split(' ');
            if (palabras.Length >= 3)
            {
                // El primer elemento es el nombre
                string nombre = palabras[0];

                // Los dos últimos elementos son los apellidos
                string apellido1 = palabras[palabras.Length - 2];
                string apellido2 = palabras[palabras.Length - 1];

                // Imprimir los resultados
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido1: " + apellido1);
                Console.WriteLine("Apellido2: " + apellido2);
            }

            Console.Write("\n\tIntroduzca su email: ");
            cliente.EmailCliente = Console.ReadLine();

            Console.Write("\n\tIntroduzca una contraseña: ");
            cliente.ContraseniaCliente = Console.ReadLine();

            return cliente;

        }
        public void accesoCliente(List<ClienteDto>listaClientes)
        {
            ClienteDto cliente= new ClienteDto();  
            
            Console.Write("\n\tIntroduzca su email: ");
            cliente.EmailCliente=Console.ReadLine();

            Console.Write("\n\tIntroduzca su contraseña: ");
            cliente.ContraseniaCliente=Console.ReadLine();

            foreach(ClienteDto clienteDto in listaClientes)
            {
                if (clienteDto.EmailCliente.Equals(cliente.EmailCliente)&& clienteDto.ContraseniaCliente.Equals(cliente.ContraseniaCliente))
                {
                    cliente = clienteDto;
                    if (clienteDto.EsValidado == true)
                    {
                        Console.WriteLine("\n\t INICIO DE SESIÓN CORRECTO");
                    }
                    else
                    {
                        Console.WriteLine("\n\t No puede acceder ya que no esta validado");
                    }
                }
            }
            
        }
    }
}
