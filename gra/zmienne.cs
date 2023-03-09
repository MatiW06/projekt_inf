using System;

namespace gra01
{




    public partial class akcja
    {
        public class zmienne { public int playerHealth;
            public int enemyHealth; 
            public int cash; 
            public int round;
            public zmienne() 
            { playerHealth = 100; cash = 50; round = 0; 
                int min = 30;
                int max = 150;

                Random randomNum = new Random();


                int randNum = randomNum.Next(min, max);
                enemyHealth = randNum;

                Console.WriteLine("Enemy hp: " + randNum);
            }  }
    }
}
              
                    
               
    

    





