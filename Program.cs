using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3

{
    internal class Program
    {
         static int health;
         static int score;
         static int shield;
         static int lives; 
         static int multiplier;

        static int healthPackValue;
        static int shieldPackValue;

        static int enemieDamageValue;


        static void Main(string[] args)
        {
            score = 0;
            health = 100;
            shield = 100;
            lives = 3;

            ShowHUD();

            Console.ReadKey(true);

            playerKilledScreen();
            



          
        }
        // This is the quick code for showing the HUD


        static void ShowHUD()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("========Your Stats========");
            Console.WriteLine("=");
            Console.WriteLine("=Score: " + score + "   Multiplier: " + multiplier + "x");
            Console.WriteLine("=");
            Console.WriteLine("=Health: " + health + "   Shield: " + shield);
            Console.WriteLine("=");
            Console.WriteLine("=Lives: " + lives);
            Console.WriteLine("==========================");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.ReadKey(true);

        }


       
        
        
        //These are the power ups that affect the HUD in a good way

        static void HealthPack()
        {
            health = health + healthPackValue;
        }


        static void ShieldPack()
        {
            shield = shield + shieldPackValue;
        }


        
        
        
        //These are the impacts that affect the HUD in a bad way


        static void PlayerAttacked()
        {
            health = health + enemieDamageValue;
        }


        static void playerKilledScreen()
        {
            health = 100;
            shield = 100;
            lives = lives - 1;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine(" You died! " + lives + " lives remain");
            Console.WriteLine("==========================");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.Beep(400, 300);
            Console.Beep(380, 1000);
        }

       


        
          

        
    }
}
