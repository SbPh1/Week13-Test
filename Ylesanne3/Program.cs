using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ToyotaData = @"C:\Users\monkey\samples\Week13\toyota.txt";
            string BMWData = @"C:\Users\monkey\samples\Week13\bmw.txt";
            string CarsData = @"C:\Users\monkey\samples\Week13\cars.txt";

            List<string> toyota = new List<string>();
            List<string> bmw = new List<string>();

            string[] sourceData = File.ReadAllLines(CarsData);

            foreach (string element in sourceData)
            {
                if (element.Contains("Toyota"))
                {
                    toyota.Add(element);
                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);
                }
                File.WriteAllLines(ToyotaData, toyota);
                File.WriteAllLines(BMWData, bmw);
            }
        }
    }
}
