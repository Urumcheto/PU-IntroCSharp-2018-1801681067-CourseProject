using System;

namespace Test2_3i
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y = 0;
            double e = Math.E;
            Console.Write("insert X:");
            x = double.Parse(Console.ReadLine());
            if (x < -4)

            {
                y = (2 * x * x) / (x + 4);
            }
            else if (x >= -4 && x <= 4)
            {
                y = 0;
            }
            else if (x > 4)
            {
                y = Math.Log(x - 4) * Math.Pow(e, x) / (Math.Pow(x, 5) + Math.Sqrt(x));
            }
            Console.WriteLine($"Y={y}");
}


    }
}
