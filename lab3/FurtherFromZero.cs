using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class FurtherFromZero:IOperation
    {
        public string getOperation() { return "FFZ(a,b)"; }
        public string getName() { return "Более далекое число от 0"; }
        public int calculation(int a, int b) { if(Math.Abs(a)== Math.Max(Math.Abs(a), Math.Abs(b))) {  return a; } else { return b; } }
    }
}
