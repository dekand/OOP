using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        double resultPrice = 0;
        double[] dropPrice = new double[7] { 240, 315, 273, 334, 452, 610, 150 };
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (coffeeType.SelectedItem!=null)
            {
                resultPrice = dropPrice[coffeeType.SelectedIndex] * Convert.ToDouble(countOfCoffee.Value);
                resultPrice += checkSugar.Checked ? 25 * Convert.ToDouble(countOfSugar.Value) : 0;
                resultPrice += cream.Checked ? 50 : 0;
                labelPrice.Text = Convert.ToString(resultPrice) + " руб.";
                labelPrice.ForeColor = Color.DarkGreen;
                labelPriceText.Visible = true;
            }
            else { labelPrice.ForeColor = Color.Red; labelPrice.Text = "Выбери кофе!";}

            labelPrice.Visible = true;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            countOfSugar.Enabled = checkSugar.Checked;
        }

        private void coffeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            countOfCoffee.Enabled = true;
        }
    }
}
