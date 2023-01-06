namespace HomeWorkCycle9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int number = Convert.ToInt32(Console.ReadLine());
            int amount = 0;
            int num = number;
            
            while (num!=0)
            {


                if ((num % 2) == 0)
                {
                    num /= 10;
                   
               }
                else 
                {
                    
                    amount++;
                    num /= 10;

                }
                   
            
            }Console.WriteLine($"{amount}");

        }
    }
}