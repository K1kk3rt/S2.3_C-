using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class RobotAdapter : IAttacker
    {
        IRobot robot;

        public RobotAdapter(IRobot robot)
        {
            this.robot = robot;
        }

        //implement interface
        public void AssignDriver()
        {
            robot.MoveByPerson();
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
