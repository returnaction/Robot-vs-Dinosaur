using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Robot_vs_Dinosaur_Bonus_3
{
    internal class BattleField
    {
        public Fleet fleet;
        public Heard heard;

        List<string> fleetPlayersNames = new List<string>();
        List<string> heardPlayersNames = new List<string>();

        Random rnd2 = new Random();
        int winnerAnnounce;

        public BattleField()
        {
            heard = new Heard();
            fleet = new Fleet();
        }

        public void WelcomeMethod()
        {
            Console.WriteLine("Welcome to the battle  for the ages!");
        }

        public void TeamSettings()
        {
            Console.WriteLine("\nHeard team settings");
            heard.dinosaur1.ChooseAGunAndName();
            heard.dinosaur2.ChooseAGunAndName();
            heard.dinosaur3.ChooseAGunAndName();

            Console.WriteLine("\nFleet team settings");
            fleet.robot1.ChooseAGunAndName();
            fleet.robot2.ChooseAGunAndName();
            fleet.robot3.ChooseAGunAndName();
        }

        public void DisplayTeamSettings()
        {
            Console.WriteLine($"\nPlayer: {heard.dinosaur1.name} - Weapon: {heard.dinosaur1.finalWeapon.name} - Attack Power: {heard.dinosaur1.finalWeapon.attackPower.ToString()}");
            Console.WriteLine($"Player: {heard.dinosaur2.name} - Weapon: {heard.dinosaur2.finalWeapon.name} - Attack Power: {heard.dinosaur2.finalWeapon.attackPower.ToString()}");
            Console.WriteLine($"Player: {heard.dinosaur3.name} - Weapon: {heard.dinosaur3.finalWeapon.name} - Attack Power: {heard.dinosaur3.finalWeapon.attackPower.ToString()}");

            Console.WriteLine($"\nPlayer: {fleet.robot1.name} - Weapon: {fleet.robot1.finalWeapon.name} - Attack Power: {fleet.robot1.finalWeapon.attackPower.ToString()}");
            Console.WriteLine($"Player: {fleet.robot2.name} - Weapon: {fleet.robot2.finalWeapon.name} - Attack Power: {fleet.robot2.finalWeapon.attackPower.ToString()}");
            Console.WriteLine($"Player: {fleet.robot3.name} - Weapon: {fleet.robot3.finalWeapon.name} - Attack Power: {fleet.robot3.finalWeapon.attackPower.ToString()}");
        }

        public int DeterningWhoStarts()
        {
            int startFirst = rnd2.Next(1, 3);
            if (startFirst == 1)
            {
                Console.WriteLine("\n__________ Randizer choose Fleet to start  __________ \n");
                return 1;
            }
            else
            {
                Console.WriteLine("\n__________ Randizer choose Heard to start  __________ \n");
                return 2;
            }
        }

        public void RoundAnouncement()
        {
            //if (fleet.robot1.health < 0)
            //    fleet.robot1.health = 0;
            //if (fleet.robot2.health < 0)
            //    fleet.robot2.health = 0;
            //if (fleet.robot3.health < 0)
            //    fleet.robot3.health = 0;
            //if (heard.dinosaur1.health < 0)
            //    heard.dinosaur1.health = 0;
            //if (heard.dinosaur2.health < 0)
            //    heard.dinosaur2.health = 0;
            //if (heard.dinosaur3.health < 0)
            //    heard.dinosaur3.health = 0;
            Console.WriteLine($"\n Fleet: {fleet.robot1.name} HP {fleet.robot1.health}  || Heard: {heard.dinosaur1.name} HP {heard.dinosaur1.health}");
            Console.WriteLine($" Fleet: {fleet.robot2.name} HP {fleet.robot2.health}  || Heard: {heard.dinosaur1.name} HP {heard.dinosaur2.health}");
            Console.WriteLine($" Fleet: {fleet.robot3.name} HP {fleet.robot3.health}  || Heard: {heard.dinosaur1.name} HP {heard.dinosaur3.health}");
        }

        public void WinnerOfTheGame(int winnerAnnounce)
        {
            if (winnerAnnounce == 1)
            {
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________          Congratualiations!           __________ ");
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________         The winner is HEARD!          __________ ");
                Console.WriteLine("__________                                       __________ ");
            }
            else
            {
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________          Congratualiations!           __________ ");
                Console.WriteLine("__________                                       __________ ");
                Console.WriteLine("__________         The winner is FLEET!          __________ ");
                Console.WriteLine("__________                                       __________ ");
            }
        }

        public int BattleSequence()
        {

            int start = DeterningWhoStarts();

            if (start == 1)
            {
                while (true)
                {
                    Console.WriteLine("__________            FLEET ATACKS               __________ ");
                    fleet.FleetAtack(heard);
                    RoundAnouncement();
                    Console.ReadLine();

                    Console.WriteLine("__________            HEARD ATACKS               __________ ");
                    heard.HeardAtack(fleet);
                    RoundAnouncement();
                    Console.ReadLine();

                    if (fleet.robot1.isAlive == false && fleet.robot2.isAlive == false && fleet.robot3.isAlive == false)
                    {
                        return 1;
                    }
                    if (heard.dinosaur1.isAlive == false && heard.dinosaur2.isAlive == false && heard.dinosaur3.isAlive == false)
                    {
                        return 2;
                    }
                }
            }
            else
            {
                while (true)
                {
                    Console.WriteLine("__________            HEARD ATACKS               __________ ");
                    heard.HeardAtack(fleet);
                    RoundAnouncement();
                    Console.ReadLine();

                    Console.WriteLine("__________            FLEET ATACKS               __________ ");
                    fleet.FleetAtack(heard);
                    RoundAnouncement();
                    Console.ReadLine();

                    if (fleet.robot1.isAlive == false && fleet.robot2.isAlive == false && fleet.robot3.isAlive == false)
                    {
                        return 1;
                    }
                    if (heard.dinosaur1.isAlive == false && heard.dinosaur2.isAlive == false && heard.dinosaur3.isAlive == false)
                    {
                        return 2;
                    }
                }
            }
        }

        public void RunGame()
        {
            WelcomeMethod();
            TeamSettings();
            DisplayTeamSettings();
            winnerAnnounce = BattleSequence();
            WinnerOfTheGame(winnerAnnounce);
        }
    }
}
