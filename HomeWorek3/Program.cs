namespace HomeWorek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            int b = Convert.ToInt32(Console.ReadLine());


            int c = a;
            for(int i=1; i<b; i++)
            {

                c *= a;
            }
            Console.WriteLine(c);  

            

        }
    }
}