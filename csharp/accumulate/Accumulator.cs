using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Accumulator
{

    public static IEnumerable<U> Accumulate<U,T>(this IEnumerable<T> inputArray, Func<T, U> function)
    {
        return inputArray.Select(function);
    }
}

