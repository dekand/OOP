namespace OOP_lab8
{
    internal class ZeroGenerator : IGenerator
    {
        public string getName() { return "Нулевая"; }
        public long getElement(int i, int j, int size) { return 0; }
    }
}
