using System;
using System.IO;
namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\opilane\samples\RandomQuotes.txt";
            string[] datafromfile = File.ReadAllLines(path);

            Console.WriteLine(datafromfile[0]);
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, datafromfile.Length);
            Console.WriteLine(datafromfile[randomIndex]);
        }
    }
}
