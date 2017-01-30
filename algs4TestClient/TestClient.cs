using Algorithms4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algs4TestClient
{
    class TestClient
    {
        static void Main(string[] args)
        {
            try
            {
                double[] rndNums = RandomSeq.GenerateRandomSequence(5, 10.0, 11.0);

                for (int i = 0; i < rndNums.Length; i++)
                {
                    Console.WriteLine(rndNums[i]);
                }
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
