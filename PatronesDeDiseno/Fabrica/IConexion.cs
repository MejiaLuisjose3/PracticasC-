using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Fabrica
{
    public interface IConexion
    {
        void Conctar();
        void Desconctar();
    }
}
