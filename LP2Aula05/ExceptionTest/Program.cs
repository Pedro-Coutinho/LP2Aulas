using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insere um numero inteiro: ");
            int i = 0;
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido : {i}");

            } catch (Exception){
                Console.WriteLine("Input não é um int");
            }
        }
    }
}
