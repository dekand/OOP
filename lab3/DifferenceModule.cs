using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class DifferenceModule:IOperation
    {
        public string getOperation() { return "|a-b|"; }
        public string getName() { return "Расстояние (модуль разности)"; }
        public int calculation(int a, int b) { return Math.Abs(a- b); }
    }
}
