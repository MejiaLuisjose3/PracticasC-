using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.prototipo
{
    public class program
    {
        public program()
        {

            Persona Luis = new Persona();

            Luis.Id = 1;
            Luis.Nombre = "Luis";

            var jose = Luis;
            jose.Id = 2;
            jose.Nombre = "Mejia";

            var clon = (Persona)Luis.Clone();
            clon.Id = 3;
            clon.Nombre = "Cabral";

            Console.WriteLine(Luis.Id + " " + Luis.Nombre);
            Console.WriteLine(jose.Id + " " + jose.Nombre);
            Console.WriteLine(clon.Id + " " + clon.Nombre);
            Console.ReadKey();








        }
    }
}
