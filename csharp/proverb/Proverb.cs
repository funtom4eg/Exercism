﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Proverb
{
    const string text = "For want of a nail the shoe was lost.\n" +
                        "For want of a shoe the horse was lost.\n" +
                        "For want of a horse the rider was lost.\n" +
                        "For want of a rider the message was lost.\n" +
                        "For want of a message the battle was lost.\n" +
                        "For want of a battle the kingdom was lost.\n" +
                        "And all for the want of a horseshoe nail.";
    public static string Line(int line)
    {
        return text.Split('\n')[line - 1];
    }

    public static string AllLines()
    {
        return text;
    }
}

