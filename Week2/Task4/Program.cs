using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            public static void CreateCopyDeleteFile()//funtion does operations like creating file and  copying file and then deleting file 
            {
                StreamWriter file = new StreamWriter(@"C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4\path\file.txt");//creating file   
                file.WriteLine("Erbol:) have a great day!");//writing something to inside of the file
                file.Close();//closing the file
                             //we have another method of creating the file and writing something inside though below given line
                             //"C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4\path\file.txt","Erbol:) have a great day!")

                File.Copy("C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4/path/file.txt", "C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4\path1\file.txt");//copying the file to another directory
                File.Delete("C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4\path\file.txt");//deleting the file
            }

            /*public static void CreateMoveFolder() // this function creates folder and moves it to another directory
           {
               Directory.CreateDirectory("C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4/path/file.txt");
               Directory.Move("C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4\path1\file.txt", "C:\Users\Lenovo\Desktop\PP2_2019\Week2\Task4\path1\file.txt");
           }*/

            static void Main(string[] args)
            {
                CreateCopyDeleteFile();//recalling this function
                                       //CreateMoveFolder();
                Console.ReadKey();//pausing the system
            }
        }
    }
}
