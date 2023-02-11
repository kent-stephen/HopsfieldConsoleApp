using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldSample
{
    public class Neuron
    {
        public int activation;

        public int[] weightv = new int[9];
        public Neuron(int[] j)
        {
            int i;

            for (i = 0; i < 9; i++)
            {
                weightv[i] = j[i];
            }
        }

        public int Act(int m, int[] x)
        {

            int i;

            int a = 0;

            for (i = 0; i < m; i++)
            {
                a += x[i] * weightv[i];
            }

            Console.WriteLine(a);

            return a;
        }
    }
}
