using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Adapter
{
    class USRobot : USRobotsInterface
    {
        private float CurrentSpeed;

        public float CurrentSpeedInMilesPerHour
        {
            get { return CurrentSpeed; }
            set { CurrentSpeed = value; }
        }

        public USRobot()
        {
            this.CurrentSpeed = 0;
        }

        public void EnablePartialFirstLawMode()
        {
            Console.WriteLine("Partial first law enabled");
        }

        public void Jump(float feet)
        {
            Console.WriteLine("Jump !!");
        }
    }
}
