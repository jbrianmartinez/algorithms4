using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4
{
    public class RandomSeq
    {
        private static Random rnd;

        // do not instantiate
        private RandomSeq()
        {

        }

        /// <summary>
        /// Returns n uniformly random real numbers in [lo, hi)
        /// </summary>
        /// <param name="n">number of double values to return</param>
        /// <param name="lo">double lower bound</param>
        /// <param name="hi">double higher bound</param>
        /// <returns>array of random double values</returns>
        public static double[] GenerateRandomSequence(int n, double lo, double hi)
        {
            if (!(lo < hi))
            {
                throw new Exception("lo value must be lower than hi value");
            }

            double[] rndSeq = new double[n];

            // create pseudo-random number generator
            rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = lo + rnd.NextDouble() * (hi - lo);
                rndSeq[i] = x;
            }

            return rndSeq;
        }
    }
}
