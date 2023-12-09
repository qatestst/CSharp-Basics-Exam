namespace _05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int targetForDay = int.Parse(Console.ReadLine());
            int earnedMoney = 0;

            
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "closed")
                {
                    break;
                }

                if (command == "haircut")
                {
                    string haircutType = Console.ReadLine();
                    int price = 0;

                    switch (haircutType)
                    {
                        case "mens":
                            price = 15;
                            break;
                        case "ladies":
                            price = 20;
                            break;
                        case "kids":
                            price = 10;
                            break;
                    }

                    earnedMoney += price;
                }
                else if (command == "color")
                {
                    string colorType = Console.ReadLine();
                    int price = 0;

                    switch (colorType)
                    {
                        case "touch up":
                            price = 20;
                            break;
                        case "full color":
                            price = 30;
                            break;
                    }

                    earnedMoney += price;
                }

                if (earnedMoney >= targetForDay)
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {earnedMoney}lv.");
                    return;
                }
            }

            
            int neededMoney = targetForDay - earnedMoney;
            Console.WriteLine($"Target not reached! You need {neededMoney}lv. more.");
            Console.WriteLine($"Earned money: {earnedMoney}lv.");
        }
    }
}