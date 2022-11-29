using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Joiner joiner = new Joiner("First String");
            Action<String> myDel = PrintUpper;
            myDel += PrintLower;
            myDel += joiner.JoinAndPrint;

            myDel.Invoke("Second String!");
        }

        public static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
}
