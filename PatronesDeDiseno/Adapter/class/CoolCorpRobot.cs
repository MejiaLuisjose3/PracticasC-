using PatronesDeDiseno.Adapter.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseno.Adapter 
{
    class CoolCorpRobot : CoolCorpInterface
    {
        private USRobot robot;

        public CoolCorpRobot()
        {
            this.robot = new USRobot();
        }

        public float CurrentSpeedInKilometersPerHour
        {
            get
            {
                return this.robot.CurrentSpeedInMilesPerHour * 1.6093f;
            }
            set
            {
                this.robot.CurrentSpeedInMilesPerHour = value * 0.62137f;
            }
        }

        public void Jump(float meters)
        {
            this.robot.Jump(meters * 0.3048f);
        }
    }
}
