using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Raindrops
{
    public static string Convert(int number)
    {
        string result = "";
        if (number % 3 == 0)
            result += "Pling";
        if (number % 5 == 0)
            result += "Plang";
        if (number % 7 == 0)
            result += "Plong";
        return result.Length == 0 ? number.ToString() : result;
    }
}

