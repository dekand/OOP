using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_2
{
    public class Ball
    {
        private Panel panel;
        private int step, size, x0, y0;

        public Ball(Panel panel, int step, int size, int x0, int y0)
        {
            this.panel = panel;
            this.step = step;
            this.size = size;
            this.x0 = x0; 
            this.y0 = y0;
        }

        public void run()
        {
            int x=x0, y=y0;
            int xdir=+1, ydir=+1;

            Graphics gr = panel.CreateGraphics();
            while (true)
            {
                gr.Clear(Color.AliceBlue);
                gr.DrawEllipse(Pens.Green, x, y, size, size);
                try
                {
                    Thread.Sleep(20);
                } catch(Exception e) { Console.WriteLine(e.Message); }
                if (x > panel.Width - size) { xdir = -1; }
                if (x < 0) { xdir = +1; }
                if (y > panel.Height - size) { ydir = -1; }
                if (y < 0) { ydir = +1; }
                x += xdir * step; y += ydir * step;
            }
        }
    }
}
