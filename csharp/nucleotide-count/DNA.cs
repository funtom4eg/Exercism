using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidNucleotideException : Exception
{

}

public class DNA
{
    private string _dna;
    private Dictionary<char, int> _counter;

    public DNA(string dna)
    {
        _dna = dna;
        _counter = new Dictionary<char, int>() { { 'A', 0 }, { 'C', 0 }, { 'T', 0 }, { 'G', 0 } };
        foreach (char c in _dna)
        {
            _counter[c]++;
        }
    }

    public Dictionary<char, int> NucleotideCounts
    {
        get
        {
            return _counter;
        }
    }

    public int Count(char c)
    {
        if (_counter.ContainsKey(c))
        {
            return _counter[c];
        }
        else throw new InvalidNucleotideException();
    }
}

