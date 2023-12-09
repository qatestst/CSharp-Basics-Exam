namespace _03._Final_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string country = Console.ReadLine();


            double totalAmount = 0;

            if (country == "Bulgaria")
            {
                totalAmount = numberOfDancers * points;
                if (season == "summer")
                {
                    totalAmount -= totalAmount * 0.05;
                }
                else if (season == "winter")
                {
                    totalAmount -= totalAmount * 0.08;
                }
            }
            else if (country == "Abroad")
            {
                totalAmount = (numberOfDancers * points) + 0.5 * (numberOfDancers * points);
                if (season == "summer")
                {
                    totalAmount -= totalAmount * 0.1;
                }
                else if (season == "winter")
                {
                    totalAmount -= totalAmount * 0.15;
                }
            }


            double charityAmount = 0.75 * totalAmount;
            double moneyPerDancer = (totalAmount - charityAmount) / numberOfDancers;


            Console.WriteLine($"Charity - {charityAmount:F2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
        }
    }
}