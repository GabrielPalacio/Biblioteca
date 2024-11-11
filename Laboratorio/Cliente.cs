using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Cliente
    {
        private String nro;
        private EstadoCliente estado;
        private Double tiempoIngreso;
        private Double tiempoSalida;

        public Cliente(string nro, EstadoCliente estado, double tiempoIngreso, double tiempoSalida)
        {
            this.nro = nro;
            this.estado = estado;
            this.tiempoIngreso = tiempoIngreso;
            this.tiempoSalida = tiempoSalida;
        }

        public string Nro { get => nro; set => nro = value; }
        public EstadoCliente Estado { get => estado; set => estado = value; }
        public double TiempoIngreso { get => tiempoIngreso; set => tiempoIngreso = value; }
        public double TiempoSalida { get => tiempoSalida; set => tiempoSalida = value; }

        public override string ToString()
        {
            return estado + " (" + tiempoIngreso + " - " + tiempoSalida + ")";
        }
    }
}
