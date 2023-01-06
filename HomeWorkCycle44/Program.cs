namespace HomeWorkCycle4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int b=a;

            for (int i = 1; i<a; i++)
            {
                
                
                if ((b % i) == 0)
                {
                   
                    c = i;

                }



                

            }
            Console.WriteLine($"{c}");
        }
    }
}