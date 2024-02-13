using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resetWin_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(PlayersClub.getPlayers);
            listBox2.Items.Clear();
        }

        private void takeOne_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                List<string> selected = new List<string>();
                foreach (var item in listBox1.SelectedItems) { if (!listBox2.Items.Contains(item)) { listBox2.Items.Add(item.ToString()); } selected.Add(item.ToString()); }
                foreach (var select in selected) { listBox1.Items.Remove(select); }
            }
        }

        private void takeAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items) { if (!listBox2.Items.Contains(item)) listBox2.Items.Add(item.ToString()); }
            listBox1.Items.Clear();
        }

        private void removeOne_Click(object sender, EventArgs e)
        {
            List <string> selected = new List<string>();
            foreach (var item in listBox2.SelectedItems) { if (!listBox1.Items.Contains(item)) { listBox1.Items.Add(item.ToString()); } selected.Add(item.ToString()); }
            foreach (var select in selected) { listBox2.Items.Remove(select); }
        }

        private void removeAll_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items) { if (!listBox1.Items.Contains(item)) { listBox1.Items.Add(item.ToString()); } }
            listBox2.Items.Clear();
        }

        private void saveTeam_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                string teamStr = "";
                var team = listBox2.Items;
                for (var i = 0; i < listBox2.Items.Count; i++)
                {
                    teamStr += team[i].ToString() + "\n";
                }
                DialogResult res = MessageBox.Show(teamStr, "Выбраны следущие игроки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?","Подтвердите выход", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
