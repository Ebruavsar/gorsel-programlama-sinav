using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upButton_Click(object sender, EventArgs e)
        {

            if (button1.Location.Y >= 0 && button1.Location.Y <= 250)
            {
                if (button1.Location.Y != 0)
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 1);
            }

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            if (button1.Location.X >= 0 && button1.Location.X <= 250)
            {
                if (button1.Location.X != 250)
                    button1.Location = new Point(button1.Location.X + 1, button1.Location.Y);
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            if (button1.Location.X >= 0 && button1.Location.X <= 250)
            {
                if (button1.Location.X != 0)
                {
                    button1.Location = new Point(button1.Location.X - 1, button1.Location.Y);
                }
            }

        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (button1.Location.Y >= 0 && button1.Location.Y <= 250)
            {
                if (button1.Location.Y != 250)
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 1);
            }
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            button1.Location = new Point(rnd.Next(0, 250), rnd.Next(0, 250));
        }

        private void button1_LocationChanged(object sender, EventArgs e)
        {
            if (button1.Location.X <= 250 && button1.Location.Y <= 250)
            {
                textBox1.Text = button1.Location.X.ToString() + "," + button1.Location.Y.ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    string[] location = textBox1.Text.Split(',');
                    int x = Convert.ToInt32(location[0]);
                    int y = Convert.ToInt32(location[1]);
                    if (x <= 250 && y <= 250)
                    {
                        button1.Location = new Point(x, y);
                    }
                    else
                        MessageBox.Show("Hatalı giriş");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı giriş");
                }

            }
        }
    }
}
