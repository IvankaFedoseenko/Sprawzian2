using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawzian2
{
    internal class Child : Human
    {
        public override string EatSnack()
        {
            return "Ice Cream!";
        }
        public string Sing()
        {
            return "Baby shark doo doo doo doo";
        }
    }
}
