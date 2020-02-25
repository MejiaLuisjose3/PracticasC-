using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Fabrica
{
    public class Mysql : IConexion
    {
        public void Conctar()
        {
            Console.WriteLine("Conectado a Mysql");

        }

        public void Desconctar()
        {
            Console.WriteLine("Desconectado de Mysql");

        }
    }
}
