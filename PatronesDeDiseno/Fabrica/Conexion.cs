using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Fabrica
{
    public class Conexion
    {
        public void GetConexion()
        {
            FabricaImplement fabrica = new FabricaImplement();

            var fabri = fabrica.GetConexion("SQL");
            fabri.Conctar();
            fabri.Desconctar();
        }
        
    }
}
