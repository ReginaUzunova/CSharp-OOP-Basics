using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Core
{
    public class Engine
    {
        public void Run()
        {
            Smartphone smartphone = new Smartphone();

            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            for (int i = 0; i < numbers.Length; i++)
            {
                smartphone.Call(numbers[i]);
            }

            for (int i = 0; i < sites.Length; i++)
            {
                smartphone.Browse(sites[i]);
            }
        }
    }
}
