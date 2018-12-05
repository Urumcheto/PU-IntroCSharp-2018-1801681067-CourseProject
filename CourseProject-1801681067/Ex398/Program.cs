using System;

namespace Ex398
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write($"How long is this month ? ");
                bool isNumber = int.TryParse(Console.ReadLine(), out int monthDays);
                if (isNumber == false || monthDays > 31 || monthDays < 0)
                {
                    do
                    {
                        Console.Write("Months are maximum 31 days long! ");
                        isNumber = int.TryParse(Console.ReadLine(), out monthDays);
                    } while (isNumber == false || monthDays > 31 || monthDays < 0);
                }


                double[] rainStationA = RainInput(monthDays);
                double averageRainA = AverageRainInMonth(rainStationA);
                Console.WriteLine($"The average rain for station 'A' is: {averageRainA}");
                IsDayRainMoreThanMonthAverage(rainStationA, averageRainA);

                double[] rainStationB = RainInput(monthDays);
                double averageRainB = AverageRainInMonth(rainStationB);
                Console.WriteLine($"The average rain for station 'B' is: {averageRainB}");
                IsDayRainMoreThanMonthAverage(rainStationB, averageRainB);

                double[] rainStationC = RainInput(monthDays);
                double averageRainC = AverageRainInMonth(rainStationC);
                Console.WriteLine($"The average rain for station 'C' is: {averageRainC}");
                IsDayRainMoreThanMonthAverage(rainStationC, averageRainC);


            }

            private static double[] RainInput(int daysInMonth)
            {
                var rainArray = new double[daysInMonth];
                bool isNumber = false;
                for (int i = 0; i < rainArray.Length; i++)
                {
                    Console.Write($"Enter rain value for day {i + 1}: ");
                    isNumber = double.TryParse(Console.ReadLine(), out rainArray[i]);
                    if (isNumber == false || rainArray[i] < 0)
                    {
                        do
                        {
                            Console.Write("Please input non negative number: ");
                            isNumber = double.TryParse(Console.ReadLine(), out rainArray[i]);
                        } while (isNumber == false || rainArray[i] < 0);
                    }
                }

                return rainArray;
            }

            private static double AverageRainInMonth(double[] rainForMonth)
            {
                double rainSum = 0;
                foreach (var rainForDay in rainForMonth)
                {
                    rainSum += rainForDay;
                }
                double averageRain = rainSum / rainForMonth.Length;
                return averageRain;
            }

            private static void IsDayRainMoreThanMonthAverage(double[] rainArray, double averageRain)
            {

                for (int i = 0; i < rainArray.Length; i++)
                {
                    if (rainArray[i] > averageRain)
                    {
                        Console.WriteLine($"The rain for {i + 1} day is more than the average for the month!");
                    }
                }
            }
        }
    }
        }
    
