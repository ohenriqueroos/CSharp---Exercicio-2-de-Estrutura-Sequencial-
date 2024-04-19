using System;
using System.Globalization;

namespace SequentialStrucutureExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = pi * radius * radius;

            Console.WriteLine("A=" + result.ToString("F4"));
        }
    }
}