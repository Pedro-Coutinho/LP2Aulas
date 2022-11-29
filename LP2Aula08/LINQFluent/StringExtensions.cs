using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace LINQFluent
{
    public static class StringExtensions
    {
        private static Random random;

        static StringExtensions()
        {
            random = new Random();
        }
        public static string ToRandomCase(this string s)
        {
            
            StringBuilder newS = new StringBuilder();

            foreach(char c in s)
            {

                double rndN = random.NextDouble();
                if(rndN <= 0.5)
                {
                    newS.Append(char.ToUpper(c));
                }
                else
                {
                    newS.Append(char.ToLower(c));
                }   
            }
            return newS.ToString();
            
        }
        
    }
}