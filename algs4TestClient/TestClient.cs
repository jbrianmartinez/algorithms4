using Algorithms4;
using System;

namespace algs4TestClient
{
    class TestClient
    {
        static void Main(string[] args)
        {
            try
            {
                double[] rndNums = RandomSeq.GenerateRandomSequence(20, 0.0, 10.0);

                for (int i = 0; i < rndNums.Length; i++)
                {
                    Console.WriteLine(rndNums[i]);
                }
                Console.WriteLine("Average of rndNums is " + Average.GetAverage(rndNums).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            finally
            {
                Console.Write("Press any key to continue...");
                var foo = Console.ReadKey();
            }
        }
    }
}
