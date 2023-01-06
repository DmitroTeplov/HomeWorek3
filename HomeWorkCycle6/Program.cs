namespace HomeWorkCycle6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = 0;
            int c = 1;
            int d = 0;
           
            for (int i=0;i<a;i++ ) 
            {
                if ((i % 2) == 0)
                {
                    b = c + d;
                    c = b;
                    Console.WriteLine($"{b}");
                }
                else 
                {
                    b = c + d;
                    d = b;
                    Console.WriteLine($"{b}");

                }
                
               
            
            }
        }
        
    }
}