using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.generica
{
    public static class Programa
    {
        public static void generico()
        {
            var texto = new Model<string>();
            var numero = new Model<int>();


            texto.vec.Add("Luis");
            numero.vec.Add(1);

            texto.vec.Add("Jose");
            numero.vec.Add(2);

            texto.vec.Add("Mejia");
            numero.vec.Add(3);

            texto.vec.Add("Cabral");
            numero.vec.Add(4);

            foreach (var item in numero.vec)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
