namespace HomeWorkCycle3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            int b;
            for (int i = 1; i < a; i++)
            {
                b = i * i;
                if (b <= a)
                {
                    c++;
                }




            }
            Console.WriteLine($"{c}");
        }

    }
}