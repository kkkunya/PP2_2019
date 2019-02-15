using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Lenovo\Desktop\pp2\WriteLines2.txt"); //reading the value of string from the txt file on folder(by link)
            string[] arr = text.Split(); // creating string array "arr" that has value of splited(without spaces) "text"
            int k = arr.Length;  // we are getting the length of word and saving on int type "k"
            int[] a = new int[k]; // creating new array with length "ss"
            string output = ""; // creating string "output"
            bool check = false; // bool argument that taken value "false"
            Console.WriteLine(k);
            for (int i = 0; i < k; i++) // run through the loop
            {
                a[i] = int.Parse(arr[i]); // rewriting "arr" array to the "a"(converting string to int)

                for (int j = 2; j < a[i] / 2; j++) //if number is prime, then we need to check whether number is divisible till itself
                {
                    if (a[i] % j == 0) // if it divides to numbers in interval between 1 and itself, then it is not prime
                    {
                        check = true; // bool argument that taken value "true"
                        break;
                    }
                }

                if (check == false) // bool argument that taken value "false"
                {
                    output = output + a[i] + " "; // add the numbers which is prime
                }
                check = false;
            }

            System.IO.File.WriteAllText(@"C:\Users\Lenovo\Desktop\pp2\output.txt", output); // path of folder where it should write prime numbers
        }
    }
}

        }
    }
}
