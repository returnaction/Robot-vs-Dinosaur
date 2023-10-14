using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosaur_Bonus_3
{
    internal class Robot
    {
        public string name;
        public int health = 100;
        public Weapon finalWeapon;
        public bool isAlive = false;
        public List<Weapon> weapons = new List<Weapon>();

        public Weapon activeBluster = new Weapon("Bluster", 13);
        public Weapon activeLaserGun = new Weapon("LaserGun", 11);
        public Weapon activeCanon = new Weapon("Canon", 15);

        public Robot(string name)
        {
            this.name = name;
            isAlive = true;
            weapons.Add(activeBluster);
            weapons.Add(activeLaserGun);
            weapons.Add(activeCanon);
        }

        public void ChooseAGunAndName()
        {
            string tempForWeapon;
            Console.WriteLine($"{name} enter name: ");
            name = Console.ReadLine();
            if (name == "" || name == " ")
            {
                Console.WriteLine("unknown");
            }

            Console.WriteLine($"{name} choose a Weapon: ");
            while (true)
            {
                for (int i = 1; i < weapons.Count + 1; i++)
                {
                    Console.WriteLine($"Press {i} - {weapons[i - 1].name}");
                }

                tempForWeapon = Console.ReadLine();

                if (tempForWeapon == "1" || tempForWeapon == "2" || tempForWeapon == "3")
                {
                    break;
                }
                {
                    Console.WriteLine("\n***** Wrong input, must be 1,2 or 3 *****");
                }
            }

            switch (tempForWeapon)
            {
                case "1":
                    finalWeapon = weapons[0];
                    break;
                case "2":
                    finalWeapon = weapons[1];
                    break;
                case "3":
                    finalWeapon = weapons[2];
                    break;
            }
        }

        public void Attack(Dinosaur dinosaur)
        {
            dinosaur.health -= finalWeapon.attackPower;

            Console.WriteLine($"Player: {name} attacks Player: {dinosaur.name} ===> with DMG[{finalWeapon.attackPower}]");

            if (dinosaur.health <= 0)
            {
                Console.WriteLine($"                                           <{dinosaur.name}> is DEAD!");
                dinosaur.isAlive = false;
                dinosaur.health = 0;
                
            }
        }
    }
}
