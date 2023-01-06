using System.ComponentModel;

namespace HomeWorkCycle5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = 0;
           
            if (a>b) 
            {
                for (int i = b; i <= a; i++)
                {
                    if ((i%7)==0)
                    {
                        c += i; 


                    }

                }
            }
            else
            {
                for (int i = a; i <= b; i++) 
                {
                    if ((i % 7) == 0) 
                    {
                        c += i;
                    
                    }
                }

          
             }
            Console.WriteLine($"{c}");
        }
    }
}