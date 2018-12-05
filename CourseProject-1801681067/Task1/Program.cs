using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2067;
            string binery = Convert.ToString(number, 2);
            string binery1 = Convert.ToString(number, 8);
            string binery2 = Convert.ToString(number, 16);
            Console.WriteLine(binery);
            Console.WriteLine(binery1);
            Console.WriteLine(binery2);

        }
    }
}
