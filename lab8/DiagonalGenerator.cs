using System;

namespace OOP_lab8
{
    internal class DiagonalGenerator : IGenerator
    {
        private Random rand = new Random();
        public string getName() { return "Диагональная"; }
        public long getElement(int i, int j, int size) { return i != j ? 0 : rand.Next(1, 100); }
    }
}
