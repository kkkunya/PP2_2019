using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true; // creating boolean "f"
            string text = System.IO.File.ReadAllText(@"C:\Users\Lenovo\Desktop\pp2\WriteLines.txt");
            int t = text.Length; // we are getting the length of word and saving on int type "t"
            for (int i = 0; i < t / 2; i++) // loop that runs in half of word
            {
                if (text[i] == text[t - i - 1]) // if first symbol and last symbol aren`t equal(equation should work) then it goes to next step
                    f = true; // then bool expression changes to "true"
                else
                    f = false; // then bool expression changes to "false"
            }
            if (f == true) // if bool expression equal to "true"
                Console.WriteLine("Yes"); // then word is palindrome
            else
                Console.WriteLine("No"); // else it`s not

            Console.Read();
        }
    }
}
