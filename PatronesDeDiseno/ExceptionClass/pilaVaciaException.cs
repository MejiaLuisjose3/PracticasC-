using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno
{
    public class pilaVaciaException : Exception
    {
        public pilaVaciaException(string message) : base("Hay un error coño: " + message)
        {
        }
    }
}
