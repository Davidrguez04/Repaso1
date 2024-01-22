using Repaso1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Servicios
{
    internal class ImplFunciones:InterfazFunciones
    {
        public void validarCliente(List<ClienteDto>listaClientes)
        {
            ClienteDto cliente= new ClienteDto();
            

            foreach(ClienteDto clienteDto in listaClientes)
            {
                Console.WriteLine("\n\t\\\\\\\\\\");
                Console.WriteLine("\tDNI: "+clienteDto.DniCliente);
                Console.WriteLine("\tNOMBRE: "+clienteDto.NombreCompletoCliente);
                Console.WriteLine("\t\\\\\\\\\\");

            }

            Console.Write("\n\tDni del cliente que quiere validar: ");
            cliente.DniCliente = Console.ReadLine();
            
            foreach(ClienteDto clienteDto in listaClientes)
            {
                if (clienteDto.DniCliente.Equals(cliente.DniCliente))
                {
                    cliente = clienteDto;
                    cliente.EsValidado = true;
                }
            }


        }

        public void mostrarClientes(List<ClienteDto> listaClientes)
        {
            foreach(ClienteDto cliente in listaClientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

        public void borrarCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto cliente = new ClienteDto();

            Console.Clear();

            Console.WriteLine("\n\tIntroduzca el dni del cliente que quiere borrar: ");
            cliente.DniCliente = Console.ReadLine();

            foreach(ClienteDto clienteDto in listaClientes)
            {
                if (clienteDto.DniCliente.Equals(cliente.DniCliente))
                {
                    cliente = clienteDto;
                }
            }
            listaClientes.Remove(cliente);
        }
    }
}
