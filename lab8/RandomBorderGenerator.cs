using System;

namespace OOP_lab8
{
    internal class RandomBorderGenerator : IGenerator
    {
        private Random rand = new Random();
        public string getName() { return "Случайная по краям"; }
        public long getElement(int i, int j, int size) { return i == 0 || j == 0 || i == size - 1 || j == size - 1 ? rand.Next(100) : 0; }
    }
}
