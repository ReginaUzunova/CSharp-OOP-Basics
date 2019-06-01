using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(startDate, endDate);

            Console.WriteLine(dateModifier.CalculateDifference(startDate, endDate));
        }
    }
}
