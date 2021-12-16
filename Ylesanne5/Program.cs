using System;
using System.IO;

namespace Ylesanne5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\monkey\samples\funfacts.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            Console.WriteLine(dataFromFile[0]);

            Random rnd = new Random();
            int randomIndex = rnd.Next(1, dataFromFile.Length);
            Console.WriteLine(dataFromFile[randomIndex]);

            
        }
    }
}
