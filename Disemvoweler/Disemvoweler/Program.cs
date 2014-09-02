using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }

        static void Disemvoweler(string input)
        {
            //Convert to lowercase for simplicity
            string lower = input.ToLower();
            //String for vowel checking
            string vowels = "aeiou";
            //String for consonant checking
            string consonants = "bcdfghjklmnpqrstvxyz";
            //Empty strings to build on
            string onlyVowels = string.Empty;
            string consonantCounter = string.Empty;

            //Check each char to see if it's a vowel
            foreach (char c in lower)
            {
                //Add vowel to new string if found
                if (vowels.Contains(c))
                {
                    onlyVowels = onlyVowels + c;
                }
                //Add consonant to new string if found
                else if(consonants.Contains(c))
                {
                    consonantCounter = consonantCounter + c;
                }
            }

            //Return string, new string w/o vowels & the vowels
            Console.WriteLine("\nOriginal: " + input + "\nDisemvoweled: " + consonantCounter.ToUpper() + "\nJust the vowels: " + onlyVowels.ToUpper());
        }
    }
}
