namespace _06._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumberLimit = int.Parse(Console.ReadLine());
            int secondNumberLimit = int.Parse(Console.ReadLine());
            int thirdNumberLimit = int.Parse(Console.ReadLine());

            for (int i = 111; i <= 999; i++) 
            { 
                

                
                int thirdDigit = 0;
                int secondDigit = 0;
                int firstDigit = 0;
                
                bool secondDigitisPrime = false;
                bool firstDigitIsOK = false;
                bool thirdDigitIsOK = false;

                for (int j = 1; j <= 3; j++)
                {
                    int num = i;
                    thirdDigit = num % 10;
                    num = num / 10;
                     secondDigit = num % 10;
                    num = num/10;
                     firstDigit = num;
                                     
                }

                
                if (firstDigit <= firstNumberLimit && firstDigit % 2 == 0)
                { firstDigitIsOK = true; }

                if (secondDigit <= secondNumberLimit)
                {
                    if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
                    { secondDigitisPrime = true; }
                }
                if (thirdDigit <= thirdNumberLimit && thirdDigit % 2 == 0 && thirdDigit !=0)
                { thirdDigitIsOK = true; }

                if (firstDigitIsOK && secondDigitisPrime && thirdDigitIsOK)
                {
                    Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
                }


            }
        }
    }
}