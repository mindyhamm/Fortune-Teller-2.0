using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ask the user for the user’s first name
          Ask the user for the user’s last name
          Ask the user for the user’s age
          Ask the user for the user’s birth month (as an 'int')
          Ask the user for the user’s favorite ROYGBIV color
          If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
          Ask the user for the number of siblings the user has*/

            string firstName;
            string lastName;
            int age;
            int birthMonth;
            string color;
            string helpROYGBIV;
            int siblings;
            char R;
            char O;
            char Y;
            char G;
            char B;
            char I;
            char V;




            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month? Enter as a number");
            birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?");
            color = Console.ReadLine();

            Console.Write("If you do not know what ROYGBIV is, enter 'HELP' to get a list of the ROYGBIV colors.");

            bool HELP == true;
            if (HELP)
            {
                (Console.ReadLine(HELP);
            }
            /*  int R = red;
               int O = orange;
               int Y = yellow;
               int G = green;
               int B = blue;
               int I = indigo;
               int v = violet;*/

            //should be a color or HELP

            //Use switch case for each color

            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            //PART2
            // use modules for even/odd calculation
        }
    }
}
