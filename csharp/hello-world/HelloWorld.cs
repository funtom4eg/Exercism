using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HelloWorld
{
    public static object Hello(string name)
    {

        if (name == null)
            return string.Format("Hello, World!");
        else
            return string.Format("Hello, {0}!", name);
    }
}

