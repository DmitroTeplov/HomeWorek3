namespace HomeWorkCycle11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int evenNum = 0;
            int notEvenNum = 0;
            int num = 0;

            for (int i = 1; i < number; i++)
            {
                num = i;
                evenNum = 0;
                notEvenNum = 0;
                int checkNum = 1;
                while (checkNum!=0)
                {

                    checkNum = num % 10;
                    if (checkNum > 0)
                    {
                        num /= 10;
                        if ((checkNum % 2) == 0)
                        {
                            evenNum += checkNum;
                        }
                        else
                        {
                            notEvenNum += checkNum;

                        }
                    }
                }
                if (evenNum>notEvenNum) 
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}