using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class Grains
{
    public static double Square(int sq)
    {
        
        return Math.Pow(2, sq-1);
    }

    public static double Total()
    {
        double result = 0;
        for (int i = 1; i <= 64; i++)
            result += Square(i);
        return result;
    }
}

