using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Hamming
{
    public static int Compute(string dna1, string dna2)
    {
        int counter = 0;

        for (int i = 0; i < dna1.Length; i++)
        {
            if (dna1[i] != dna2[i])
                counter++;
        }
        return counter;
    }
}

