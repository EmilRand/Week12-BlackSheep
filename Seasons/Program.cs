using System;
using System.IO;
namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string autumnpath = @"C:\Users\opilane\samples\Autumn.txt";
            string winterpath = @"C:\Users\opilane\samples\Winter.txt";
            string[] dataFromAutumn = File.ReadAllLines(autumnpath);
            string[] dataFromWinter = File.ReadAllLines(winterpath);

            File.WriteAllLines(autumnpath, dataFromWinter);
            File.WriteAllLines(winterpath, dataFromAutumn);
            
        }
    }
}
