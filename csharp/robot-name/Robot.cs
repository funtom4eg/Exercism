using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Robot
{
    public string Name { get; set; }

    private static Random rand = new Random();
    private static List<string> robotList = new List<string>();

    public Robot()
    {
        do
        {
            Name = GenerateName();
        }
        while (robotList.Contains(Name));
        robotList.Add(Name);
    }

    private string GenerateName()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append((char)rand.Next((int)'A', (int)'Z'));
        builder.Append((char)rand.Next((int)'A', (int)'Z'));

        builder.Append(rand.Next(0, 9));
        builder.Append(rand.Next(0, 9));
        builder.Append(rand.Next(0, 9));

        return builder.ToString();
    }
    public void Reset()
    {
        robotList.Remove(Name);
        Name = GenerateName();
    }
}

