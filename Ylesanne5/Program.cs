using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So Interesting You'll Say, OMG!");
            Console.WriteLine("How many facts would you like to display?");
            int usernumber = Convert.ToInt32(Console.ReadLine());

            GetFacts(usernumber);
        }
        private static void GetFacts(int factsNumber)
        {
            string filepath = @"C:\Users\monkey\samples\FunFacts.txt";
            string[] randomFacts = File.ReadAllLines(filepath);

            if (factsNumber > randomFacts.Length)
            {
                factsNumber = randomFacts.Length;
            }

            for (int i = 0; i < factsNumber; i++)
            {
                Console.WriteLine(randomFacts[i]);
            }
        }
    }
}
