using System;
using System.Collections.Generic;

namespace Task_7_PolessUP
{
    class Program
    {
        static void NearNumeric(int FirsrtNumeric)
        {
            List<int> NumericalSymbols = new List<int> { };

            while (FirsrtNumeric != 0)
            {
                NumericalSymbols.Add(FirsrtNumeric % 10);
                FirsrtNumeric /= 10;
            }
            
            NumericalSymbols.Sort();
            NumericalSymbols.Reverse();

            string MaxNumeric = "";
            foreach (int x in NumericalSymbols)
            {
                MaxNumeric += x;
            }
            Console.WriteLine(MaxNumeric);
        }
        static void Main(string[] args)
        {
            NearNumeric(71273);
        }
    }
}
