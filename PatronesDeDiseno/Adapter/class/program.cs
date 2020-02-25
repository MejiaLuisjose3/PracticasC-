using PatronesDeDiseno.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Adapter
{
    public class program
    {
        public program()
        {
            CoolCorpInterface robot = new CoolCorpRobot();
            robot.CurrentSpeedInKilometersPerHour = 3;
            robot.Jump(12);

        }
    }
}
