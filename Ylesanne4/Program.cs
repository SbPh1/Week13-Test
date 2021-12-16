﻿using System;
using System.IO;

namespace Ylesanne4
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootdirect = $@"C:\Users\monkey\samples\Kasutajakaust";
            Console.WriteLine("What file would you like displayed?");
            string userFile = Console.ReadLine();
            string fileDirect = $@"{rootdirect}\{userFile}.txt";
            bool exists = File.Exists(fileDirect);

            if (exists)
            {
                string[] dataFromFile = File.ReadAllLines(fileDirect);
                if (userFile == "planets" || userFile == "stars")
                {
                    foreach (string line in dataFromFile)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine($"{userFile}.txt does not exist.");
                }

            }
            else
            {
                Console.WriteLine($"{userFile}.txt does not exist");
            }
        }
    }
}