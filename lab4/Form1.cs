using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "Производителем "+comboBox1.SelectedItem+" является "+CountryInfo.info[comboBox1.SelectedIndex];
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = numericUpDown1.Enabled = radioButton1.Enabled = radioButton2.Enabled = checkBox1.Checked; 
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && textBox2.Text.Length>2) { textBox3.Text = "Добрый день, "+textBox2.Text+"!"; }
        }
    }
}
