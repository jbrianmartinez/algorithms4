using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4
{
    public class Average
    {
        private Average()
        {

        }

        public static double GetAverage(double[] inputs)
        {
            int count = 0;
            double sum = 0.0;

            for (int i = 0; i < inputs.Length; i++)
            {
                double value = inputs[i];
                sum += value;
                count++;
            }

            return sum / count;
        }
    }
}
