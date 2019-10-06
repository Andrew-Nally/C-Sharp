using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = { "I have a ", "You have a ", "We all have a " };

            Console.WriteLine("Please enter a noun: ");
            string nouns = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences.SetValue(sentences[i] + nouns, i);
            }

            for (int j = 0; j < sentences.Length; j++)
            {
                Console.WriteLine(sentences[j]);
            }

            string[] infinite = { "\nThis", "will", "run", "forever" };

            ///infinite loop:
            ///for (int i = 0; i < infinite.Length)
            ///{
                ///Console.WriteLine(infinite[i]);
            ///}
            
            ///fixed infinite loop:         
            for (int i = 0; i < infinite.Length; i++)
            {
                Console.WriteLine(infinite[i]);
            }


            ///*******This one confuses me a little... It says "to determine whether to continue iterating the loop." That reads to me
            ///like it wants me to stop once it hits something that meets that criteria. If so, I would do it like I did below. If not,
            ///I'd rewrite it without the break so it includes the numbers after. Please let me know if you want me to redo this part.
            
            List<int> mayDrive  = new List<int>() { 63, 17, 43, 13, 53, 38, 12 };

            foreach (int age in mayDrive)
            {
                if (age < 16)
                {
                    Console.WriteLine("\n" + age + " is not old enough to drive.");
                    break;
                }
            }

            List<int> mayRide = new List<int>() { 60, 52, 72, 48, 59, 47, 67 };

            foreach (int inch in mayRide)
            {
                if (inch <= 48)
                {
                    Console.WriteLine("\nYou must be taller than 48 inches to ride. You are only " + inch + " inches. You may not ride.");
                    break;
                }
            }

            List<string> pets = new List<string>() { "dog", "bird", "cat", "emu", "tiger", "koala" };
            Console.WriteLine("\nWould you like to own a dog, bird, cat, emu, tigard or koala?");

            foreach (string pet in pets)
            {
                string petChoice = Console.ReadLine();
                while (!pets.Contains(petChoice))
                {
                    Console.WriteLine("Please choose between a dog, bird, cat, emu, tiger or koala.");
                    Console.WriteLine("\nWould you like to own a dog, bird, cat, emu, tigard or koala?");
                    petChoice = Console.ReadLine();
                }

                if (pets.Contains(petChoice))
                {
                    Console.WriteLine(petChoice + " is number " + pets.IndexOf(petChoice) + " in our list.");
                    break;
                }
                
            }

            List<string> colors = new List<string>() { "red", "blue", "yellow", "red", "blue", "yellow", "yellow" };
            Console.WriteLine("\nWhat's your favorite primary color? (If kindergarten was a few years ago... red, blue and yellow)");
            string colorChoice = Console.ReadLine();

            if (colorChoice != "red" ^ colorChoice != "yellow" ^ colorChoice != "blue")
            {
                Console.WriteLine("You must choose red, yellow or blue.");
                Console.WriteLine("\nWhat's your favorite primary color? (If kindergarten was a few years ago... red, blue and yellow)");
                colorChoice = Console.ReadLine();
            }

            string val = "";
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i] == colorChoice)
                    val = (val + i.ToString() + ", ");
            }
            val = val.Remove(val.Length - 2);
            Console.WriteLine("\n" + colorChoice + " is at the indexes: " + val);

            Console.WriteLine("\n");

            List<string> newList = new List<string>() { };
            List<string> dispatchPositions = new List<string>() { "SO1", "SO2", "Relief", "BV", "HB", "Relief", "Lead", "Lead" };
            foreach (string position in dispatchPositions)
            {
                if (newList.Contains(position))
                {
                    Console.WriteLine(position + " is already in the list.");
                }
                else
                {
                    newList.Add(position);
                    Console.WriteLine(position + " is on the list for the first time.");
                }
            }


        Console.ReadLine();
        }
    }
}
