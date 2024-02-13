using System;

namespace OOP_lab8
{
    internal class RandomGenerator : IGenerator
    {
        private Random rand = new Random();
        public string getName() { return "Случайная"; }
        public long getElement(int i, int j, int size) { return rand.Next(100); }
    }
}
