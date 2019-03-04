using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a tank (and assign it to a driver)
            IAttacker tank = new Tank();
            tank.AssignDriver();

            // create a robot (and let it move by a person)
            IRobot robot = new Robot();
            robot.MoveByPerson();

            Console.WriteLine();

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(tank);
            attackers.Add(new RobotAdapter(robot));

            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
