using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal interface IOperation
    {
        string getOperation();
        string getName();
        int calculation(int a, int b);
    }
}
