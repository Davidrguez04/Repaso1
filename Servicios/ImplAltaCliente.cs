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
            
            /*foreach(ClienteDto clienteDto in listaClientes) {
                Console.WriteLine(clienteDto.ToString());
                cliente = clienteDto;
            
            }*/
            listaClientes.Add(cliente);
        }

        private ClienteDto datosCliente()
        {
            ClienteDto cliente=new ClienteDto();
            Random random = new Random();

            cliente.IdCliente=random.Next();

            Console.Write("\n\tIntroduzca su dni: ");
            cliente.DniCliente = Console.ReadLine();

            Console.Write("\n\tIntroduzca su nombre completo: ");
            cliente.NombreCompletoCliente = Console.ReadLine();

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
                }
            }
            
        }
    }
}
