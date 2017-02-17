using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class ETL
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> inputDictionary)
    {
        var newDictionary = new Dictionary<string, int>();
        foreach (KeyValuePair<int, IList<string>> pair in inputDictionary)
        {
            foreach (string str in pair.Value)
            {
                newDictionary[str.ToLower()] = pair.Key;
            }
        }
        return newDictionary;
    }
}

