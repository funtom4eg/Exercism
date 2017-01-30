using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Complement
{
    public static string OfDna(string dna)
    {
        //* `G` -> `C`
        //* `C` -> `G`
        //* `T` -> `A`
        //* `A` -> `U`
        return dna.Replace('G', '?').Replace('C', 'G').Replace('?', 'C').Replace('T', '?').Replace('A', 'U').Replace('?', 'A');
    }
}

