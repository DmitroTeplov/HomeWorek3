namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int number  = Convert.ToInt32(Console.ReadLine());
            string newNum = "";
            int checkNum = number;
            int chengedNum = 1;




            while (checkNum!=0) 
            {

                chengedNum =checkNum% 10;
               
                if (checkNum> 0) 
                {
                    checkNum /= 10;
                    newNum += chengedNum; 

                }
            
            
            }
            Console.WriteLine($"{newNum}");
        }
    }
}