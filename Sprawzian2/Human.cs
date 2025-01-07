using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawzian2
{
    internal class Human : Isinger
    {
        public string Name { get; set; }
        public virtual string EatSnack() { return "Ice cream!"; }

        public string Sing()
        {
            return "sings";
        }
    }
}
