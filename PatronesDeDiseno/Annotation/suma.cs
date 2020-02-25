using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Annotation
{
    //[Obsolete("Esta mierda no sirve")]
    public class suma
    {
        public int valorUno { get; set; }

        public int valorDos { get; set; }

        [ProbandoSuma("valorUno", "valorDos")]
        public int resultado { get; set; }
    }
}
