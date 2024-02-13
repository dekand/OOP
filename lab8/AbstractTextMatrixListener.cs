using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab8
{
    internal abstract class AbstractTextMatrixListener : Label, IMatrixListener
    {
       public void matrixUpdated(Matrix matrix)
        {
            initialization(matrix);
            for (int i = 0; i < matrix.getSize(); i++)
            {
                for (int j = 0; j < matrix.getSize(); j++)
                {
                    nextStep(matrix, i, j);
                }
            }
            finalization(matrix);
        }
        protected abstract void initialization(Matrix matrix);
        protected abstract void nextStep(Matrix matrix, int i, int j);
        protected abstract void finalization(Matrix matrix);
    }
}
