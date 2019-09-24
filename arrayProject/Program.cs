using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fortuneArray = {"You are not illiterate.", "Be kind to pigeons. A statue someday may be made of you.",
                "Your friends secretly agree your head is the wrong size for your body.", "Foot. A device for finding furniture in the dark.",
                "Stop procrastinating -- starting tomorrow." };

            bool validInput = false;

            while (validInput == false)
            {

                Console.WriteLine("Pick a number between 0 through 4 to get your daily fortune:");
                int fortuneInput = Convert.ToInt32(Console.ReadLine());

                if (fortuneInput <= 4)
                {
                    Console.WriteLine("Your daily fortune: \n" + fortuneArray[fortuneInput]);
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("\nThat's not a valid number. Please enter a number between 0 and 4");
                }
            }

            int[] luckyArray = { 34, 12, 57, 34, 23, 59, 45, 23, 40, 78 };

            bool validNum = false;

            while (validNum == false)
            {

                Console.WriteLine("\nPick a number between 0 through 9 to get your lucky number:");
                int luckyInput = Convert.ToInt32(Console.ReadLine());

                if (luckyInput <= 9)
                {
                    Console.WriteLine("Your lucky number: \n" + luckyArray[luckyInput]);
                    validNum = true;
                }
                else
                {
                    Console.WriteLine("That's not a valid number. Please enter a number between 0 and 9");
                }
            }

            List<string> stoneLst = new List<string> { "Garnet", "Amethyst", "Aquamarine, Bloodstone", "Diamond", "Emerald", "Pearl, Moonstone, Alexandrite",
            "Ruby", "Peridot, Spinel", "Sapphire", "Opal, Tourmaline", "Topaz, Citrine", "Turquoise, Zircon, Tanzanite"};

            bool validMonth = false;

            while (validMonth == false)
            {

                Console.WriteLine("\nEnter your birth month by number (January = 1, etc.) to see what your birthstone is:");
                int monthInput = Convert.ToInt32(Console.ReadLine());

                if (monthInput <= 12)
                {
                    Console.WriteLine("Your birthstone: \n" + stoneLst[monthInput - 1]);
                    validMonth = true;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You have to have been born in a month to get your birth stone...");
                }
                
            }
        }
    }
}
