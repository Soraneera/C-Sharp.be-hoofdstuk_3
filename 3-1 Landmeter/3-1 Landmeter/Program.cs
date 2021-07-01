using System;

namespace _3_1_Landmeter
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            Double AB, AC, RC, RA, AG, CG, RARC;

            //Obtaining Variables
            Console.WriteLine("Geef hoek A in grade: ");
            AG = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef hoek C in grade: ");
            CG = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef afstand van A naar C in meters: ");
            AC = Convert.ToDouble(Console.ReadLine());

            //Calculation
            RA = (AG) * Math.PI / 180;
            RC = (CG) * Math.PI / 180;
            RARC = RA + RC;
            AB = AC * Math.Sin(RC) / Math.Sin(RARC);

            //Result
            Console.WriteLine("De afstand van A naar B is {0} meter", AB);
        }
    }
}
