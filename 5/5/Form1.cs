using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
            {
                int moveStep = 5;
                if (e.KeyCode == Keys.Up)
                    textBox1.Top -= moveStep;
                else if (e.KeyCode == Keys.Down)
                    textBox1.Top += moveStep;
                else if (e.KeyCode == Keys.Left)
                    textBox1.Left -= moveStep;
                else if (e.KeyCode == Keys.Right)
                    textBox1.Left += moveStep;
            }

            else if (e.Alt && (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
            {
                int resizeStep = 5;
                if (e.KeyCode == Keys.Up)
                    textBox1.Height -= resizeStep;
                else if (e.KeyCode == Keys.Down)
                    textBox1.Height += resizeStep;
                else if (e.KeyCode == Keys.Left)
                    textBox1.Width -= resizeStep;
                else if (e.KeyCode == Keys.Right)
                    textBox1.Width += resizeStep;
            }

            else if (e.Shift && e.KeyCode == Keys.Back)
            {
                textBox1.Clear();
            }

            else if (e.Alt && e.KeyCode == Keys.F5)
            {
                textBox1.Text = textBox1.Text.ToUpper();
            }

            else if (e.Control && e.KeyCode == Keys.F5)
            {
                textBox1.Text = textBox1.Text.ToLower();
            }

            else if (e.KeyCode == Keys.F10)
            {
                Application.Exit();
            }

        }
    }
}
