using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Bob
{
    public static string Hey(string question)
    {
        if (question.Except(" ").Count() == 0)
            return "Fine. Be that way!";
        else if (Regex.IsMatch(question, "[A-Z]") && !Regex.IsMatch(question, "[a-z]"))
            return "Whoa, chill out!";
        else if (question.Except(" ").Last() == '?')
            return "Sure.";
        else return "Whatever.";
    }
}

