namespace _01._Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paperRolls = double.Parse(Console.ReadLine());
            double linenRolls = double.Parse(Console.ReadLine());
            double glueLiters = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine())/100;

            double paperRollsPrice = 5.80;
            double linenRollsPrice = 7.20;
            double glueLitersPrice = 1.20;

            double totalPrice = paperRolls*paperRollsPrice + linenRolls*linenRollsPrice + glueLiters*glueLitersPrice;
            double PriceAfterDiscount = totalPrice - totalPrice*discount;
            Console.WriteLine($"{PriceAfterDiscount:F3}");


        }
    }
}