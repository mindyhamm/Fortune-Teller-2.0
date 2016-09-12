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
            string favColor;
            int siblings;
                       
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your birth month? Enter as a number.");
            birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your favorite ROYGBIV color?");
            favColor = Console.ReadLine();
                
            Console.WriteLine("If you do not know what ROYGBIV is, enter 'HELP' to get a list of the ROYGBIV colors.");
            color = Console.ReadLine();

            bool HELP = true;

            if(HELP==true)
            {
                Console.WriteLine("R = red\nO = orange\nY = yellow\nG = green\nB = blue\nI = indigo\nV = violet");
            }
            Console.WriteLine("How many siblings do you have?");
            siblings = int.Parse(Console.ReadLine());

            //PART2   // use modules for even/odd calculation |
            /*int userAge = (this is where i would insert an decrement -- or increment ++ for odd/even yrs of age?
            int siblingZero 
            int siblingOne
            var locationOne
            var locationTwo
            var store?
            if userAge odd "you will retire in __ yrs" || if userAge even "you will retire in __yrs"
            || user siblingZero "you will have a vacation home in __ || if siblingOne "you will have a vacation home in __"
            || user has siblingTwo "you will live in locationThree" || siblingThree "you will live in locationFour 
            ||


            PART3
            [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
        }
    }
}
