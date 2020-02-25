using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.seale
{
    class Z : Y
    {
        // Attempting to override F causes compiler error CS0239.  
        //   
        //protected override void F()
        //{
        //    Console.WriteLine("C.F");
        //}
        // Overriding F2 is allowed.   
        protected override void F2()
        {
            Console.WriteLine("Z.F2");
        }
    }
}
