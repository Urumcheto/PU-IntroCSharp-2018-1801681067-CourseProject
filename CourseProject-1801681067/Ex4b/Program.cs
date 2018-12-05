using System;

namespace Ex4b
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter number for 'x': ");
                double x = double.Parse(Console.ReadLine());

                Console.Write("Enter number for 'y': ");
                double y = double.Parse(Console.ReadLine());

                Console.Write("Enter number for 'z': ");
                double z = double.Parse(Console.ReadLine());

                decimal result = (decimal)Math.Pow(x + 2, Math.Pow(y + 1, z + 3));
                Console.WriteLine(result);
            }
        }
    }
}
