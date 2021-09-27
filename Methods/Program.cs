using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{



    class Program
    { 
      //declarations: only exists in brackets theyre inside of. // if it doesnt work try using static for multiple.

    static int score;
    static string name;
    static int xp;

        // A method that shows the HUD.
        static void ShowHUD()
        {


            //Shows HUD
            Console.WriteLine("==========");
            Console.WriteLine("score = " + score);
            Console.WriteLine("name = " + name);
            Console.WriteLine("xp = " + xp);
            Console.WriteLine();
            Console.WriteLine("==========");
        }

        static void Main(string[] args)
        {
            //Methods:
            //(AKA Procedures, functions, ...)

            Console.WriteLine("Methods:");
            Console.WriteLine("------");


            //declarations: only exists in brackets theyre inside of.
            int score;
            string name;
            int xp;
           
            // ...

            //initialize
            score = 0;
            name = "Bran_Fakes";
            xp = 0;

            //hud easy way to copy and paste
            //ShowHUD();




            // simulated gameplay
            score = score + 100;
            xp = xp + 50;

            ShowHUD();

            Console.WriteLine("score = " + score);
            Console.WriteLine("name = " + name);
            Console.WriteLine("xp = " + xp);
            Console.WriteLine();


            ShowHUD();

            score = score * 10;
            xp = xp + 100;

            ShowHUD();







            Console.ReadKey(true); // click to exit or continue.
        }
    }
}
