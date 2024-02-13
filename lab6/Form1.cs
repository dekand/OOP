using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Ball ball1 = new Ball(panel1, 2, 60, 150, 150);
            Ball ball2 = new Ball(panel1, 4, 40, 200, 50);
            Ball ball3 = new Ball(panel1, 1, 70, 120, 200);

            Task task1 = Task.Run(() =>  ball1.run());
            Task task2 = Task.Run(() =>  ball2.run());
            Task task3 = Task.Run(() =>  ball3.run());
        }
    }
}
