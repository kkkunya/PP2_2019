﻿using System;
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
                StreamWriter file = new StreamWriter(@"C:\Users\Aida\Desktop\pp2\PP2\week2\Task4\path\file.txt");//creating file   
                file.WriteLine("Smile:) have a great day!");//writing something to inside of the file
                file.Close();//closing the file
                             //we have another method of creating the file and writing something inside though below given line
                             //"C:\Users\Aida\Desktop\pp2\PP2\week2\Task4\path\file.txt","Smile:) have a great day!")

                File.Copy("C:/Users/Aida/Desktop/pp2/PP2/week2/Task4/path/file.txt", "C:/Users/Aida/Desktop/pp2/PP2/week2/Task4/path1/file.txt");//copying the file to another directory
                File.Delete("C:/Users/Aida/Desktop/pp2/PP2/week2/Task4/path/file.txt");//deleting the file
            }

            /*public static void CreateMoveFolder() // this function creates folder and moves it to another directory
           {
               Directory.CreateDirectory("C:/Users/Aida/Desktop/pp2/PP2/week2/Task4/path/file");
               Directory.Move("C:/Users/Aida/Desktop/pp2/PP2/week2/Task4/path/file", "C:/Users/Aida/Desktop/pp2/PP2/week2/Task4/path1/file");
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
