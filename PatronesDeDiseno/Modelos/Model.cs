using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Modelos
{
    public class Model
    {
        public int status { get; set; }
        public bool isSuccess { get; set; }
        public Result result { get; set; }
        public object error { get; set; }
    }

    public class Result
    {
        public string certificateKey { get; set; }
        public int id { get; set; }
    }
    
}
