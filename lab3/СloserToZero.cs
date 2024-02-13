using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class СloserToZero:IOperation
    {
        public string getOperation() { return "CTZ(a,b)"; }
        public string getName() { return "Более близкое число к 0"; }
        public int calculation(int a, int b) { if (Math.Abs(a) == Math.Min(Math.Abs(a), Math.Abs(b))) { return a; } else { return b; } }
    }
}
