using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Adapter
{
    interface USRobotsInterface
    {
        float CurrentSpeedInMilesPerHour { get; set; }
        void EnablePartialFirstLawMode();
        void Jump(float feet);
    }
}
