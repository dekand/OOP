namespace OOP_lab8
{
    internal class CalcMax : AbstractTextMatrixListener
    {
        long res;
        protected override void initialization(Matrix matrix)
        {
            res = matrix.getValue(0, 0);
        }
        protected override void nextStep(Matrix matrix, int i, int j)
        {
            if (res < matrix.getValue(i, j)) res = matrix.getValue(i, j);
        }
        protected override void finalization(Matrix matrix)
        {
            Text = res.ToString();
        }
    }
}
