using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerInfo;

namespace CharacterCreation
{
    class CreateCharacter
    {
        static public void CharacterPrompts()
        {
            Player player = new Player();

            // Prompt user to create character
            Console.WriteLine("Please enter your character's name:");
            player.name = Console.ReadLine();
            

            Console.WriteLine("Please enter your character's gender (M/F/NB):");
            player.gender = Console.ReadLine();
            

            Console.WriteLine("Please enter your character's date of birth (MM/DD/YYYY):");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            dob = player.dob;



            // Ask user to choose starting class
            Console.WriteLine("Choose your starting class: Warrior or Mage");
            string startingClass = Console.ReadLine();

            // Set starting statistics based on class
            
            if (startingClass.ToLower() == "warrior")
            {
                player.hp = 20;
                player.fp = 5;
                player.patk = 6;
                player.pdef = 5;
                player.matk = 2;
                player.mdef = 1;
                player.spd = 3;
                player.luc = 1;
            }
            else if (startingClass.ToLower() == "mage")
            {
                player.hp = 10;
                player.fp = 10;
                player.patk = 3;
                player.pdef = 2;
                player.matk = 6;
                player.mdef = 4;
                player.spd = 3;
                player.luc = 1;
            }
            else
            {
                Console.WriteLine("That option is invalid.");
                Console.WriteLine("Choose your starting class: Warrior or Mage");

            }

            // Print character information
            Console.WriteLine($"Name: {player.name}");
            Console.WriteLine($"Gender: {player.gender}");
            Console.WriteLine($"Date of Birth: {dob}");
            Console.WriteLine($"Starting Class: {startingClass}");
            Console.WriteLine("Starting Statistics:");
            Console.WriteLine($"HP: {player.hp}");
            Console.WriteLine($"FP: {player.fp}");
            Console.WriteLine($"PATK: {player.patk}");
            Console.WriteLine($"PDEF: {player.pdef}");
            Console.WriteLine($"MATK: {player.matk}");
            Console.WriteLine($"MDEF: {player.mdef}");
            Console.WriteLine($"SPD: {player.spd}");
            Console.WriteLine($"LUC: {player.luc}");

            Console.WriteLine("Is this acceptable? Y/N: ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                // start game
            }
            else if (answer.ToLower() == "n")
            {
                CharacterPrompts();
            }
        }
    }
}
