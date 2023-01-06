namespace HomeWorkCycle8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            
            int number = Convert.ToInt32(Console.ReadLine());

            int middle = number / 2;
            int start = 0;
            int end = number;
            int n = middle * middle * middle;
            
            while (n != number)
            {
                if(number<n) 
                {
                  
                    end = middle;
                    middle = (end + start) / 2;
                    n = middle * middle * middle;

                }
                else
                {
                    start = middle;
                    middle = (end + start)/2;
                    n = middle * middle * middle;

                    
                }
               
            }

            Console.WriteLine($"{middle}");
        }

        

    }

    
}