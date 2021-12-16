using System;
using System.IO;

namespace Ylesanne1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\monkey\samples";
            Console.WriteLine("Vali uue kausta nimi");
            string directory = Console.ReadLine();
            string createDirectory = $@"{rootPath}\{directory}";

            bool directoryExists = Directory.Exists(createDirectory);

            if (directoryExists)
            {
                Console.WriteLine($"{directory} already exists in Samples");
            }
            else
            {
                Console.WriteLine($"Kaust {directory} on loodud");
                Directory.CreateDirectory(createDirectory);
            }
        }
    }
}
