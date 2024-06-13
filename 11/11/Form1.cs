using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen bir kategori adı girin.");
                return;
            }

            if (radioButton1.Checked)
            {
                // Kök düğüm olarak ekle
                treeView1.Nodes.Add(textBox1.Text);
            }
            else if (radioButton2.Checked && treeView1.SelectedNode != null)
            {
                // Seçili düğüm altında alt düğüm olarak ekle
                treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                treeView1.SelectedNode.Expand();
            }
            else
            {
                MessageBox.Show("Lütfen bir düğüm seçin veya kök düğüm olarak eklemek için seçeneği işaretleyin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir düğüm seçin.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
            
        }
    }
}
