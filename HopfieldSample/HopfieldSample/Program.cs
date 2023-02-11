using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int[] patrn1 = { -1, -1, -1, 1, 1, 1, -1, -1, -1 }; // minus
            //int[] patrn1 = { -1, -1, -1, -1, -1, -1, 1, 1, 1 }; // minus 3rd row
            int[] patrn1 = { 1, -1, -1, 1, 1, 1, -1, -1, -1 }; // plus
            //int[] patrn1 = { -1, 1, -1, 1, 1, 1, 1, 1, 1 }; // tank
            //int[] patrn1 = { -1, -1, 1, -1, 1, -1, 1, -1, -1 }; // back slash

            int[] wt1 = { 0, 0, 2, -2, -2, -2, 2, 0, 2 };
            int[] wt2 = { 0, 0, 0, 0, 0, 0, 0, 2, 0 };
            int[] wt3 = { 2, 0, 0, -2, -2, -2, 2, 0, 2 };
            int[] wt4 = { 2, 0, -2, 0, 2, 2, -2, 0, -2 };
            int[] wt5 = { 2, 0, -2, 2, 0, 2, -2, 0, -2 };
            int[] wt6 = { 2, 0, -2, 2, 2, 0, -2, 0, -2 };
            int[] wt7 = { 2, 0, 2, -2, -2, -2, 0, 0, 2 };
            int[] wt8 = { 0, 2, 0, 0, 0, 0, 0, 0, 0 };
            int[] wt9 = { 2, 0, 2, -2, -2, -2, 2, 0, 0 };

            Console.WriteLine("\nTHIS PROGRAM IS FOR A HOPFIELD NETWORK WITH A SINGLE LAYER OF");
            Console.WriteLine("\n4 FULLY INTERCONNECTED NEURONS. THE NETWORK SHOULD RECALL THE");
            Console.WriteLine("\nPATTERNS 1010 AND 0101 CORRECTLY.\n");

            //create the network by calling its constructor. 
            Network h1 = new Network(wt1, wt2, wt3, wt4, wt5, wt6, wt7, wt8, wt9);

            //present a pattern to the network and get the activations of the neurons 
            h1.Activation(patrn1);

            //check if the pattern given is correctly recalled and give message 
            for (int i = 0; i < 9; i++)
            {
                if (h1.output[i] == patrn1[i])
                    Console.WriteLine("\n pattern= " + patrn1[i] + " output = " + h1.output[i] + " component matches");
                else
                    Console.WriteLine("\n pattern= " + patrn1[i] + " output = " + h1.output[i] + " discrepancy occurred");
            }

            Console.WriteLine("\n\n");

        //    int[] patrn2 = { 0, 1, 0, 1 };
        //    h1.Activation(patrn2);
        //    for (int i = 0; i < 9; i++)
        //    {
        //        if (h1.output[i] == patrn2[i])
        //            Console.WriteLine("\n pattern= " + patrn2[i] + " output = " + h1.output[i] + " component matches");
        //        else
        //            Console.WriteLine("\n pattern= " + patrn2[i] + " output = " + h1.output[i] + " discrepancy occurred");
        //    }

            Console.ReadLine();
        }
    }
}
