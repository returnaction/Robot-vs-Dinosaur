using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosaur_Bonus_3
{
    internal class Fleet
    {
        public string name = "Fleet";
        public List<Robot> robots = new List<Robot>();
        public Robot robot1 = new Robot("robot1");
        public Robot robot2 = new Robot("robot2");
        public Robot robot3 = new Robot("robot3");

        Random rnd = new Random();

        public Fleet()
        {
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }

        public void FleetAtack(Heard heard)
        {
            Dinosaur dinosaur1 = heard.dinosaur1;
            Dinosaur dinosaur2 = heard.dinosaur2;
            Dinosaur dinosaur3 = heard.dinosaur3;

            int random = rnd.Next(1, 4);

            //Logic for robot 1
            if (robot1.isAlive == true)
            {
                random = rnd.Next(1, 4);

                if (random == 1)
                {
                    if (dinosaur1.isAlive == true)
                    {
                        robot1.Attack(dinosaur1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        robot1.Attack(dinosaur2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        robot1.Attack(dinosaur3);
                    }
                }
                else if (random == 2)
                {
                    if (dinosaur2.isAlive == true)
                    {
                        robot1.Attack(dinosaur2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        robot1.Attack(dinosaur3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        robot1.Attack(dinosaur1);
                    }

                }
                else if (random == 3)
                {
                    if (dinosaur3.isAlive == true)
                    {
                        robot1.Attack(dinosaur3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        robot1.Attack(dinosaur1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        robot1.Attack(dinosaur2);
                    }
                }
            }

            //Logic for robot 2
            if (robot2.isAlive == true)
            {
                random = rnd.Next(1, 4);

                if (random == 1)
                {
                    if (dinosaur1.isAlive == true)
                    {
                        robot2.Attack(dinosaur1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        robot2.Attack(dinosaur2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        robot2.Attack(dinosaur3);
                    }
                }
                else if (random == 2)
                {
                    if (dinosaur2.isAlive == true)
                    {
                        robot2.Attack(dinosaur2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        robot2.Attack(dinosaur3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        robot2.Attack(dinosaur1);
                    }

                }
                else if (random == 3)
                {
                    if (dinosaur3.isAlive == true)
                    {
                        robot2.Attack(dinosaur3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        robot2.Attack(dinosaur1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        robot2.Attack(dinosaur2);
                    }
                }
            }

            //Logic for robot 3
            if (robot3.isAlive == true)
            {
                random = rnd.Next(1, 4);

                if (random == 1)
                {
                    if (dinosaur1.isAlive == true)
                    {
                        robot3.Attack(dinosaur1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        robot3.Attack(dinosaur2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        robot3.Attack(dinosaur3);
                    }
                }
                else if (random == 2)
                {
                    if (dinosaur2.isAlive == true)
                    {
                        robot3.Attack(dinosaur2);
                    }
                    else if (dinosaur3.isAlive == true)
                    {
                        robot3.Attack(dinosaur3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        robot3.Attack(dinosaur1);
                    }

                }
                else if (random == 3)
                {
                    if (dinosaur3.isAlive == true)
                    {
                        robot3.Attack(dinosaur3);
                    }
                    else if (dinosaur1.isAlive == true)
                    {
                        robot3.Attack(dinosaur1);
                    }
                    else if (dinosaur2.isAlive == true)
                    {
                        robot3.Attack(dinosaur2);
                    }
                }
            }
        }
    }
}
