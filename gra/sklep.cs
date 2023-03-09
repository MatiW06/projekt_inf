using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gra01.akcja;

namespace ConsoleApp24
{
    public class sklep
    {
        public static void shop(zmienne z)

        {          
            Console.WriteLine("witaj w mym sklepie!");
            Console.WriteLine("wybierz co chcesz zakupić");
            Console.WriteLine("a - miksturkę zdrowia  \t b - nowy kolorek do konsoli");
            string wybierz = Console.ReadLine();          
            if (wybierz == "a")
            {
                z.playerHealth += 10;
                z.cash -= 10;
                Console.WriteLine("You heal yourself, but it costs 10");
              
            }
            else if (wybierz == "b")
            {
                Console.WriteLine("good option, choose the colour, A - blue, B - green, C - red, D - yellow");
                z.cash -= 15;
                string colour = Console.ReadLine();
                switch (colour)
                {
                    case "A":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("looks nice, am I ringht?");
                        break;
                    case "B":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("looks nice, am I ringht?");
                        break;
                    case "C":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("looks nice, am I ringht?");
                        break;
                    case "D":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("looks nice, am I ringht?");
                        break;
                    default:
                        Console.WriteLine("Choose A,B, C or D");
                        break;

                }
                Console.WriteLine($"you have now {z.cash} cash");
            }
        }
    }
}
        
    
