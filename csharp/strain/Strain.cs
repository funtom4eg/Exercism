using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> input, Func<T, bool> predicate)
    {
        return input.Where(predicate);
    }
    public static IEnumerable<T> Discard<T>(this IEnumerable<T> input, Func<T, bool> predicate)
    {
        return input.Except(input.Keep(predicate));
    }
}

