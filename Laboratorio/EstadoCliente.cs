using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class EstadoCliente
    {
        public static readonly EstadoCliente LEYENDO = new EstadoCliente("LEYENDO");
        public static readonly EstadoCliente ESPERANDO_ATENCION = new EstadoCliente("ESPERANDO_ATENCION");
        public static readonly EstadoCliente SIENDO_ATENDIDO = new EstadoCliente("SIENDO_ATENDIDO");
        public string Nombre { get; private set; }

        private EstadoCliente(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
