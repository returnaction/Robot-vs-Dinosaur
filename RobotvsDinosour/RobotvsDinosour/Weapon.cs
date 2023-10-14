using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosaur_Bonus_3
{
    internal class Weapon
    {
        public string name;
        public int attackPower;
        
        public Weapon(string name, int attackPower)
        {
            this.name = name;
            this.attackPower = attackPower;
        }
    }
}
