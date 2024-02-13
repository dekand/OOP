namespace OOP_lab8
{
    internal class IdentityGenerator : IGenerator
    {
        public string getName() { return "Единичная"; }
        public long getElement(int i, int j, int size) { return i == j ? 1 : 0; }
    }
}
