using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x, y, width, height;
        private Color currentColor = Color.Black;
        private int currentThickness = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            DrawShape();
            x= int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            width = int.Parse(textBox3.Text); height = int.Parse(textBox4.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(Color.White);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label14.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            label15.Text = $"X: {e.X}, Y: {e.Y}";

            // Mouse basılıyken hareket edildiğinde çizim yap
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = panel2.CreateGraphics())
                {
                    Pen pen = new Pen(currentColor, currentThickness);
                    g.DrawLine(pen, lastPoint, e.Location);
                }
                lastPoint = e.Location;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            currentColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            currentColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            currentColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                currentThickness = 1;
            }
            else if (radioButton3.Checked)
            {
                currentThickness = 3;
            }
            else if (radioButton2.Checked)
            {
                currentThickness = 5;
            }
        }
        private Point lastPoint;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor=Color.White;
            panel1.Paint += panel1_Paint;

            panel2.BackColor = Color.White;
            panel2.Paint += panel2_Paint;

            hScrollBar1.Maximum = 264;
            hScrollBar2.Maximum = 264;
            hScrollBar3.Maximum = 264;

        }

        private void DrawShape()
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedShape = comboBox1.SelectedItem.ToString();

                // Seçilen şekle göre çizimi yap
                if (selectedShape == "Dörtgen")
                {
                    panel1.Invalidate();
                }
                else if (selectedShape == "Daire")
                {
                    panel1.Invalidate();
                }
                else if (selectedShape == "Çizgi")
                {
                    panel1.Invalidate();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (comboBox1.SelectedItem != null)
            {
                string selectedShape = comboBox1.SelectedItem.ToString();

                // Seçilen şekle göre çizimi yap
                if (selectedShape == "Dörtgen")
                {
                    g.DrawRectangle(new Pen(Color.Red), x, y, width, height);
                }
                else if (selectedShape == "Daire")
                {
                    g.DrawEllipse(new Pen(Color.Red), x, y, width, height);
                }
                else if (selectedShape == "Çizgi")
                {
                    g.DrawLine(new Pen(Color.Red), x, y, x + width, y + height);
                }
            }
        }
    }
}
