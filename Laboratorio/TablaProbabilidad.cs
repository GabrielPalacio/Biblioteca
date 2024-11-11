using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class TablaProbabilidad
    {
        int operacion;
        string nombreOperacion;
        double pr;
        double pr_acum;


        public double Pr { get => pr; set => pr = value; }
        public double Pr_acum { get => pr_acum; set => pr_acum = value; }
        public int Operacion { get => operacion; set => operacion = value; }
        public string NombreOperacion { get => nombreOperacion; set => nombreOperacion = value; }
    }
}
