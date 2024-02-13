namespace OOP_lab8
{
    internal class CalcNonZeroElements : AbstractTextMatrixListener
    {
        long res;
        protected override void initialization(Matrix matrix)
        {
            res = 0;
        }
        protected override void nextStep(Matrix matrix, int i, int j)
        {
            res += matrix.getValue(i, j) != 0 ? 1 : 0;
        }
        protected override void finalization(Matrix matrix)
        {
            Text = res.ToString();
        }
    }
}
