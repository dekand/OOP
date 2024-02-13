namespace OOP_lab8
{
    internal class CalcTrace : AbstractTextMatrixListener
    {
        long res;
        protected override void initialization(Matrix matrix)
        {
            res = 0;
        }
        protected override void nextStep(Matrix matrix, int i, int j)
        {
            if(i == j) res += matrix.getValue(i, j);
        }
        protected override void finalization(Matrix matrix)
        {
            Text = res.ToString();
        }
    }
}
