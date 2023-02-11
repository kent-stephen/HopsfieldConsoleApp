using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldSample
{
    public class Network
    {
        private Neuron[] nrn = new Neuron[9];
        public int[] output = new int[9];
        private int[] testOutput = new int[9];

        public Network(int[] a, int[] b, int[] c, int[] d, int[] f, int[] j, int[] k, int[] l, int[] m)
        {
            nrn[0] = new Neuron(a);
            nrn[1] = new Neuron(b);
            nrn[2] = new Neuron(c);
            nrn[3] = new Neuron(d);
            nrn[4] = new Neuron(f);
            nrn[5] = new Neuron(j);
            nrn[6] = new Neuron(k);
            nrn[7] = new Neuron(l);
            nrn[8] = new Neuron(m);
        }

        public void Activation(int[] patrn)
        {
            var isDone = false;
            while (!isDone)
            {
                for (int i = 0; i < 9; i++)
                {
                    nrn[i].activation = nrn[i].Act(9, patrn);
                    //Console.WriteLine("\nactivation is " + nrn[i].activation);
                    testOutput[i] = Threshold(nrn[i].activation);
                    //Console.WriteLine("\noutput value is " + testOutput[i] + "\n");
                }

                if (output.SequenceEqual(testOutput))
                {
                    isDone = true;
                    Console.WriteLine("GOods");
                }
                else
                {
                    Array.Copy(testOutput, output, testOutput.Length);
                    Console.WriteLine(1);
                }
            }
        }

        public int Threshold(int k)
        {
            if (k >= 0)
                return (1);
            else
                return (-1);

        }
    }
}
