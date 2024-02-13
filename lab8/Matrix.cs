using System.Collections.Generic;

namespace OOP_lab8
{
    internal class Matrix
    {
        private int size = 10;
        private long[,] contents;
        private IGenerator generator;

        public int getSize() { return size; }
        public void setGenerator(IGenerator generator) { this.generator = generator; }
        private List<IMatrixListener> listeners = new List<IMatrixListener>();
        public void addListener(IMatrixListener listener) { listeners.Add(listener); }
        public void notifyAboutUpdate()
        {
            foreach (IMatrixListener listener in listeners)
            {
                listener.matrixUpdated(this);
            }
        }
        public void update()
        {
            contents = new long[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    contents[i, j] = generator.getElement(i, j, size);
                }
            }
            notifyAboutUpdate();
        }
        public long getValue(int i, int j) { return contents[i, j]; }

    }
}
