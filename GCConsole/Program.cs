using System;
using System.Diagnostics;
using static GCConsole.ToCompareToLower;

namespace GCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            var gcBefore = GC.CollectionCount(0);

            AuxEnum auxEnum = AuxEnum.AttrA;
            string property = "AtTRa";

            bool result = false;

            sw.Start();
            for(int i = 0; i < 1_000_000; i++)
            {
                //result = auxEnum.IsEqualWithLower(property);
                //result = auxEnum.IsEqualWithoutLower(property);
                //result = auxEnum.IsEqualWithComparison(property);
            }
            sw.Stop();

            Console.WriteLine("Time: {0}", sw.Elapsed);
            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Count: {0}", (GC.CollectionCount(0) - gcBefore));
        }

        
    }

    
}