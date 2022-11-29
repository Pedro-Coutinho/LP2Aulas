using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace LINQFluent
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] myfile = File.ReadAllLines("roger1.txt");

            int numOFlines = myfile.Count(s => s.Length > 30);
            double average = myfile.Average(s => s.Length);
            bool biggerThan120 = myfile.Any(s => s.Length > 120);
            IEnumerable<string> stringIEnum = 
                from s in myfile
                where s.Contains('Y')
                select s.Trim().Split()[0].ToRandomCase();

            Console.WriteLine(numOFlines);
            Console.WriteLine(average);
            Console.WriteLine(biggerThan120);
            
            foreach(string s in stringIEnum)
                Console.WriteLine(s);


        }
    }
}
