using System;

namespace OOP_lab8
{
    internal class RandomEvenGenerator : IGenerator
    {
        private Random rand = new Random();
        public string getName() { return "Случайная по четным столбцам и строкам"; }
        public long getElement(int i, int j, int size) { return ++i % 2 == 0 || ++j % 2 == 0 ? rand.Next(1, 100) : 0; }
    }
}
