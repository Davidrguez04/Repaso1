using Repaso1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Servicios
{
    internal interface InterfazFunciones
    {
        public void validarCliente(List<ClienteDto> listaClientes);

        public void mostrarClientes(List<ClienteDto> listaClientes);

        public void borrarCliente(List<ClienteDto> listaClientes);

    }
}
