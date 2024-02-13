using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Max:IOperation
    {
        public string getOperation() { return "MAX(a,b)"; }
        public string getName() { return "Максимум"; }
        public int calculation(int a, int b) { return Math.Max(a, b); }

    }
}
