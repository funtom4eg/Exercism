using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class PhoneNumber
{
    private string _number;
    public string Number
    {
        get
        {
            return _number;
        }
        set
        {
            if (value.Length == 11 && value[0] == '1')
            {
                _number = value.Remove(0, 1);
            }
            else if (value.Length == 10)
            {
                _number = value;
            }
            else
            {
                _number = "0000000000";
            }
        }
    }
    public string AreaCode
    {
        get
        {
            return _number.Remove(3);
        }
    }

    public PhoneNumber(string input)
    {
        Number = Regex.Replace(input, "[^0-9]", string.Empty);
    }

    public override string ToString()
    {
        return _number.Insert(0, "(").Insert(4, ") ").Insert(9, "-");
    }
}

