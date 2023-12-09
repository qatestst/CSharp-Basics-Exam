namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int modelsCount = int.Parse(Console.ReadLine());

           double totalRating = 0;
            double SumOfSales = 0;
           for (int i = 1; i <= modelsCount; i++) 
           { 
            int model = int.Parse(Console.ReadLine());
                double rating = model % 10;
                totalRating += rating;
                int sales = model / 10;
                ;
                double totalSales = 0;
                switch (rating) 
                {
                    case 2: totalSales = 0; break;
                    case 3: totalSales = 0.5;break;
                    case 4: totalSales = 0.7;break;
                    case 5: totalSales = 0.85;break;
                    case 6: totalSales = 1;break;
                    
                }
                double salesForModel = totalSales * sales;
                SumOfSales += salesForModel;
           }

            double averageRating = totalRating / modelsCount;

            Console.WriteLine($"{SumOfSales:F2}");
            Console.WriteLine($"{averageRating:F2}");
            
        }
    }
}