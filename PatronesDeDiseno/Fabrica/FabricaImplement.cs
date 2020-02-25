using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Fabrica
{
    public class FabricaImplement
    {
        public IConexion GetConexion(string motor)
        {
            if (motor == "MYSQL")
            {
                return new Mysql();
            }
            else if (motor == "SQL")
            {
                return new Sql(); 
            }
            else
            {
                return new sqLite();
            }
        }
    }
}
