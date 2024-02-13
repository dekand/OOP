namespace OOP_lab8
{
    internal class MatrixData
    {
        public static IMatrixListener[] listeners = { new CalcMax(), new CalcSum(), new CalcTrace(), new CalcNonZeroElements() };
        public static IGenerator[] generators = { new IdentityGenerator(), new ZeroGenerator(), new RandomGenerator(), new DiagonalGenerator(), new RandomBorderGenerator(), new RandomEvenGenerator() };

    }
}
