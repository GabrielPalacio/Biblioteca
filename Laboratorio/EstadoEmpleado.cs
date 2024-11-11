using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class EstadoEmpleado
    {
        public static readonly EstadoEmpleado LIBRE = new EstadoEmpleado("LIBRE");
        public static readonly EstadoEmpleado BUSCANDO_LIBRO = new EstadoEmpleado("BUSCANDO_LIBRO");
        public static readonly EstadoEmpleado RECEPTANDO_LIBRO = new EstadoEmpleado("RECEPTANDO_LIBRO");
        public static readonly EstadoEmpleado RESOLVIENDO_CONSULTAS = new EstadoEmpleado("RESOLVIENDO_CONSULTAS");
        public static readonly EstadoEmpleado OCUPADO = new EstadoEmpleado("OCUPADO");


        public string Nombre { get; private set; }

        private EstadoEmpleado(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
