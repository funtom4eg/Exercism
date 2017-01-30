using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Gigasecond
{
    public static DateTime Date(DateTime date)
    {
        return date.AddSeconds(Math.Pow(10, 9));
    }
}

