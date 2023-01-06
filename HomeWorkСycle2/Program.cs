using System;

namespace HomeWorkСycle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= 1000; i++)
            {


                if ((i % a) == 0)
                {
                    Console.WriteLine(i);

                }





            }

        }
    }
}