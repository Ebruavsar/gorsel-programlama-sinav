using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string enteredText = textBox1.Text;
            int spaceCount = CountSpacesUntilDot(enteredText);
            label1.Text = "Boşluk Sayısı: " + spaceCount.ToString();
        }
        private int CountSpacesUntilDot(string text)
        {
            int spaceCount = 0;
            foreach (char c in text)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
                else if (c == '.')
                {
                    break; 
                }
            }
            return spaceCount;
        }
    }
}
