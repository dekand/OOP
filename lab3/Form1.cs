using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string calc(int index, int a, int b)
        {
            IOperation[] operations = { new Max(), new Min(), new DifferenceModule(), new FurtherFromZero(), new СloserToZero() };
            return operations[index].getName() + ": " + operations[index].getOperation() + " = " + Convert.ToString(operations[index].calculation(a, b));
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelResultText.Text = Convert.ToString(calc(comboBoxOperation.SelectedIndex,Convert.ToInt32(numericA.Value), Convert.ToInt32(numericB.Value)));
            labelResultText.ForeColor = Color.DarkGreen;
        }
    }
}
