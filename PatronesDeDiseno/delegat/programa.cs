using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.delegat
{
    delegate int Operar(int x1, int x2);

    public class Programa
    {

        public int Sumar(int x, int y)
        {
            return x + y;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }

        internal void Operacion(Operar d, int x, int y)
        {
            Console.WriteLine(d(10, 5));
        }

        public void Funciona()
        {
            Programa p = new Programa();
            Console.WriteLine("Suma y resta de 10 y 5.");
            p.Operacion(p.Sumar, 10, 5);
            p.Operacion(p.Restar, 10, 5);
            Console.ReadKey();
        }
    }
}