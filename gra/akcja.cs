using ConsoleApp24;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace gra01
{




    public partial class akcja
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game!");          

            var z = new zmienne();
                                
            Console.WriteLine($"your hp: {z.playerHealth}, enemy hp: {z.enemyHealth}, round: {z.round}, your cash: {z.cash}");

            while (z.playerHealth > 0 && z.enemyHealth > 0 && z.cash > 0)
            {
                Console.WriteLine("Choose an action to take:");
                Console.WriteLine("1 - Attack");
                Console.WriteLine("2 - Defend");
                Console.WriteLine("3 - Run Away");
                Console.WriteLine("4 - Go to the shop");

                string action = Console.ReadLine();
                if (action == "1")
                {
                    Console.WriteLine("You attack the enemy!");
                    z.enemyHealth -= 10;
                    z.playerHealth -= 10;
                    Console.WriteLine("Enemy health is now " + z.enemyHealth);
                    Console.WriteLine("Your health is now " + z.playerHealth);
                    Console.WriteLine($"you have now {z.cash} cash");
                }
                else if (action == "2")
                {
                    Console.WriteLine("You defend yourself!");
                    z.playerHealth += 5;
                    Console.WriteLine($"Your health is now" + z.playerHealth);
                    Console.WriteLine($"you have now {z.cash} cash");
                    Console.ReadKey();
                }
                else if (action == "3")
                {
                    Console.WriteLine("you run away and unfortunately lost 5");
                    z.playerHealth -= 5;
                    z.cash -= 5;
                    Console.WriteLine($"you have now {z.cash} cash");
                }
                else if (action == "4") 
                {
                    Console.WriteLine("let's go to the shop!");
                    sklep.shop(z);
                }

                   

                
                z.round += 1;
                Console.WriteLine($"kasa: {z.cash}, runda: {z.round}, hp {z.playerHealth}");

                if (z.cash <= 0)
                {
                    Console.WriteLine("unfortunately you don't have more cash");
                    
                }
                else if (z.playerHealth <= 0)
                {
                    Console.WriteLine("you die");
                    
                }
                else if (z.enemyHealth <= 0)
                {
                    Console.WriteLine("congrats, you win!");
                    
                }
            }
        }
    }
}
              
                    
               
    

    





