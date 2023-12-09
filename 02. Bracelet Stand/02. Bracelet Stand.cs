using System;

namespace _02._Bracelet_Stand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double dailyIncomeFromSales = double.Parse(Console.ReadLine());
            double allExpenses = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double savedMoney = (5 * pocketMoney) + (5 * dailyIncomeFromSales) - allExpenses;
            double netIncome = savedMoney;

            if (savedMoney >= presentPrice)
            {
                Console.WriteLine($"Profit: {netIncome:F2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {presentPrice - netIncome:F2} BGN.");
            }
        }
    }
}