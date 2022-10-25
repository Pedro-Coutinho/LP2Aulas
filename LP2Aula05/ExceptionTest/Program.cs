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

            } catch (FormatException){
                Console.WriteLine("Input não é um Int.");
            } catch (OverflowException){
                Console.WriteLine("Input é demasiado pequena ou demasiado grande.");
            } finally{
                Console.WriteLine("Obrigado por usar este programa!");
            }
        }
    }
}
