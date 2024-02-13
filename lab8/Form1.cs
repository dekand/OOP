using System;
using System.Windows.Forms;

namespace OOP_lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            foreach (IGenerator generator in MatrixData.generators)
            {
                if (!comboBox1.Items.Contains(generator.getName())) { comboBox1.Items.Add(generator.getName()); }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix();

            foreach (IMatrixListener listener in MatrixData.listeners)
            {
                tableLayoutPanel1.Controls.Add((Label)listener);
                matrix.addListener(listener);
            }

            matrix.setGenerator(MatrixData.generators[comboBox1.SelectedIndex]);
            matrix.update();
            string text = "";
            for (int i = 0; i < matrix.getSize(); i++)
            {
                for (int j = 0; j < matrix.getSize(); j++)
                {
                    text += matrix.getValue(i, j);
                    text += "\t";
                }
                text += "\n";
            }
            textBox1.Text = text;
        }
    }
}
