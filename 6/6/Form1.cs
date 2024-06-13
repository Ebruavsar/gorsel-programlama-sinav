using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "GORSEL";
            label.Font = new Font("Arial", 12, FontStyle.Bold); 
           
            label.Location = new Point(250, 50);

            panel1.Controls.Add(label);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            UpdatePanelColor();
        }

        private void UpdatePanelColor()
        {
            Color color = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

            if (radioButton1.Checked)
            {
                panel1.BackColor = color; // Panelin arka plan rengini güncelle
            }
            else
            {
                panel1.ForeColor = color; // Panelin yazı rengini güncelle
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdatePanelColor();
        }
    }
}
