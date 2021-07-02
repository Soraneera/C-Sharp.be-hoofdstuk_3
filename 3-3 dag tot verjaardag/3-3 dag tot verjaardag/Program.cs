using System;

namespace _3_3_dag_tot_verjaardag
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DayNow = DateTime.Today;
            DateTime BDay = new DateTime(2021, 11, 29);
            TimeSpan T = BDay - DayNow;
            Console.WriteLine("dagen tot Dominiques verjaardag: {0}", T);
            Console.ReadLine();
        }
    }
}
