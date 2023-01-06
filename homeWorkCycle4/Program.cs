namespace homeWorkCycle4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            int b = Convert.ToInt32(Console.ReadLine());

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
                Console.WriteLine(a);
            }
        }
    }
}