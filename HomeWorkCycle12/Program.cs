namespace HomeWorkCycle12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int checkNumber1 = number1 % 10;
            int checkNumber2 = number2 % 10;
            int changedNum1 = number1;
            int changedNum2 = number2;

            while ((checkNumber2 != checkNumber1) && (checkNumber1 != 0))
            {
                if (checkNumber1 != 0)
                {
                    checkNumber1 = changedNum1 % 10;
                    changedNum1 /= 10;
                    changedNum2 = number2;
                    checkNumber2 = changedNum2 % 10;
                }
              

                while ((checkNumber2 != checkNumber1)&&(changedNum2 != 0))
                {
                    if (changedNum2 > 0)
                    {
                        changedNum2 /= 10;
                        checkNumber2 = changedNum2 % 10;
                    }
                    
                    
                    if ((checkNumber2 == checkNumber1)&&(checkNumber1!=0))
                    {
                        Console.WriteLine("Да");
                    }

                }

                
                
            }

            if (checkNumber1==0) 
            { Console.WriteLine("нет"); 
            }
            if (number1== number2) 
            {
                Console.WriteLine("Да");
            }



        }
    }
}