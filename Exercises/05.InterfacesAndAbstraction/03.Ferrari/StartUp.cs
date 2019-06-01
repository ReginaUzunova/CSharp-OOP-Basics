using System;

namespace Ferrari
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string driverName = Console.ReadLine();
            string model = "";

            Ferrari ferrari = new Ferrari(model, driverName);
            
            Console.WriteLine($"{ferrari.Model}/{ferrari.Brakes()}/{ferrari.Gas()}/{ferrari.Driver}");
        }
    }
}
