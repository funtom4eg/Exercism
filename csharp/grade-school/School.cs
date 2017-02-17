using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class School
{
    public Dictionary<int, List<string>> Roster = new Dictionary<int, List<string>>();

    public void Add(string name, int grade)
    {
        if (Roster.ContainsKey(grade))
        {
            Roster[grade].Add(name);
            Roster[grade].Sort();
        }
        else
        {
            Roster[grade] = new List<string>();
            Roster[grade].Add(name);
        }
        
    }

    public List<string> Grade(int grade)
    {
        if (Roster.ContainsKey(grade))
        {
            return Roster[grade];
        }
        else
        {
            return new List<string>();
        }
    }
}

