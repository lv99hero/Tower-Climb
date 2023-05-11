/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tower_Climb;
using static System.Net.Mime.MediaTypeNames;

namespace Tower_Climb
{
    class BattleSystem
    {
        // Player and enemy information
        private string playerName;
        private int playerHP;
        private int playerMaxHP;
        private int playerAttack;
        private int playerDefense;
        private int playerSpeed;

        private string enemyName;
        private int enemyHP;
        private int enemyMaxHP;
        private int enemyAttack;
        private int enemyDefense;
        private int enemySpeed;

        // Constructor to set up player and enemy information
        public BattleSystem(string playerName, int playerHP, int playerAttack, int playerDefense, int playerSpeed,
            string enemyName, int enemyHP, int enemyAttack, int enemyDefense, int enemySpeed)
        {
            this.playerName = playerName;
            this.playerHP = playerHP;
            this.playerMaxHP = playerHP;
            this.playerAttack = playerAttack;
            this.playerDefense = playerDefense;
            this.playerSpeed = playerSpeed;

            this.enemyName = enemyName;
            this.enemyHP = enemyHP;
            this.enemyMaxHP = enemyHP;
            this.enemyAttack = enemyAttack;
            this.enemyDefense = enemyDefense;
            this.enemySpeed = enemySpeed;
        }

        // Main battle loop
        public void StartBattle()
        {
            Console.WriteLine($"A battle has started between {playerName} and {enemyName}!");

            // Keep looping until either the player or enemy has been defeated
            while (playerHP > 0 && enemyHP > 0)
            {
                // Print player and enemy information
                Console.WriteLine($"{playerName} HP: {playerHP}/{playerMaxHP}");
                Console.WriteLine($"{enemyName} HP: {enemyHP}/{enemyMaxHP}");

                // Ask player for action
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Defend");
                Console.WriteLine("3. Use a skill");
                Console.WriteLine("4. Use an item");
                Console.WriteLine("5. Run away");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Player attacks
                        int damage = CalculateDamage(playerAttack, enemyDefense);
                        Console.WriteLine($"{playerName} attacks {enemyName} for {damage} damage!");
                        enemyHP -= damage;
                        break;

                    case 2:
                        // Player defends
                        Console.WriteLine($"{playerName} defends and takes reduced damage next turn.");
                        break;

                    case 3:
                        // Player uses a skill (not implemented)
                        Console.WriteLine("You don't have any skills yet!");
                        break;

                    case 4:
                        // Player uses an item (not implemented)
                        Console.WriteLine("You don't have any items yet!");
                        break;

                    case 5:
                        // Player runs away
                        Console.WriteLine($"{playerName} tries to run away!");
                        int escapeChance = CalculateEscapeChance(playerSpeed, enemySpeed);
                        if (escapeChance >= 50)
                        {
                            Console.WriteLine($"{playerName} successfully escapes!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"{playerName} was unable to escape!");
                        }
                        break;

                    default:
                        // Invalid input
                        Console.WriteLine("Invalid input!");
                        break;
                }

                // Check if enemy is defeated
                if (enemyHP <= 0)
                {
                    Console.WriteLine($"{enemyName} has been defeated!");
                    break;
                }

                // Enemy attacks
                int damage = CalculateDamage(enemyAttack, playerDefense);
                Console.WriteLine($"{enemyName} attacks {playerName} for {damage} damage!");
                playerHP -= damage;

                // Check if player is defeated
                if (playerHP <= 0)
                {
                    Console.WriteLine($"{playerName} has been defeated!");
                    break;
                }

                Console.WriteLine();
            }
        }

        // Helper function to calculate damage
        private int CalculateDamage(int attackerAttack, int defenderDefense)
        {
            int damage = attackerAttack - defenderDefense;
            if (damage < 0)
            {
                damage = 0;
            }
            return damage;
        }

        // Helper function to calculate escape chance
        private int CalculateEscapeChance(int playerSpeed, int enemySpeed)
        {
            int escapeChance = (playerSpeed - enemySpeed) * 10 + 50;
            if (escapeChance > 90)
            {
                escapeChance = 90;
            }
            else if (escapeChance < 10)
            {
                escapeChance = 10;
            }
            return escapeChance;
        }
    }
}
*/
