using Repaso1.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Servicios
{
    internal interface InterfazAltaC
    {
        public void darAltaCliente(List<ClienteDto> listaClientes);

        public void accesoCliente(List<ClienteDto> listaClientes);


    }
}
