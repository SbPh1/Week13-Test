using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\monkey\Samples\week13";
            string toyota = $@"{newPath}\toyota.txt";
            string bmw = $@"{newPath}\bmw.txt";
            string tesla = $@"{newPath}\tesla.txt";

            bool directoryExists = Directory.Exists(newPath);
            bool toyotaExists = File.Exists(toyota);
            bool bmwExists = File.Exists(bmw);
            bool teslaExists = File.Exists(tesla);

            if (directoryExists && toyotaExists && teslaExists && bmwExists)
            {
                Console.WriteLine($"{toyota} already exists");
                Console.WriteLine($"{bmw} already exists");
                Console.WriteLine($"{tesla} already exists");
            }
            else
            {
                File.Create(toyota);
                File.Create(bmw);
                File.Create(tesla);
                Console.WriteLine($"Files {toyota},{bmw} and {tesla} has been created in Week13.");
            }
            Console.ReadLine();
        }
    }
}
