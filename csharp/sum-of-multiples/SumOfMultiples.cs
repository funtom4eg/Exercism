using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfMultiples
{
    public static int To(int[] multiples, int max)
    {

        List<int> sum = new List<int>();

        foreach (var item in multiples)
        {
            for (int i = 1; item * i < max; i++)
            {
                if (!sum.Contains(item * i))
                    sum.Add(item * i);
            }
        }
        return sum.Sum();
    }
}

