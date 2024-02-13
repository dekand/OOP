using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Min : IOperation
    {
        public string getOperation() { return "MIN(a,b)"; }
        public string getName() { return "Минимум"; }
        public int calculation(int a, int b) { return Math.Min(a, b); }

    }
}
