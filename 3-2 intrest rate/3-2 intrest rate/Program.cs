using System;

namespace _3_2_intrest_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Double EK, BK, LT;

            //Getting Variables
            Console.WriteLine("Wat is het beginkapitaal? ");
            BK = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wat is de looptijd in jaren? ");
            LT = Convert.ToDouble(Console.ReadLine());

            //calculations
            EK = BK * (0.125 * LT);

            //Result
            Console.WriteLine("Het eindkapitaal bedraagt: " + Math.Round(EK, 2).ToString());
        }
    }
}
