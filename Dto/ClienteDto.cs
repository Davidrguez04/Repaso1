using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso1.Dto
{
    internal class ClienteDto
    {
        //Atributos
        int idCliente;
        string dniCliente;
        string nombreCliente;
        string apellido1Cliente;
        string apellido2Cliente;
        string nombreCompletoCliente;
        string emailCliente;
        string contraseniaCliente;
        bool esValidado=false;

        //Getters y setters
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValidado { get => esValidado; set => esValidado = value; }


        //Constructor
        public ClienteDto()
        {
        }

        public ClienteDto(int idCliente, string dniCliente, string nombreCliente, string apellido1Cliente, string apellido2Cliente, string nombreCompletoCliente, string emailCliente, string contraseniaCliente, bool esValidado)
        {
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;
            this.nombreCliente = nombreCliente;
            this.apellido1Cliente = apellido1Cliente;
            this.apellido2Cliente = apellido2Cliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            this.esValidado = esValidado;
        }


        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "\n\tId cliente: " + this.IdCliente +
                "\n\tDni:" + this.DniCliente +
                "\n\tNombre: " + this.NombreCliente +
                "\n\tApellido 1: " + this.Apellido1Cliente +
                "\n\tApellido 2: " + this.Apellido2Cliente +
                "\n\tNombre completo: " + this.NombreCompletoCliente +
                "\n\tEmail: " + this.EmailCliente +
                "\n\tEs validado: " + this.EsValidado;

            return mensaje;


        }

    }
}
