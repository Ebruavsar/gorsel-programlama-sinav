using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            string searchText = textBox1.Text;

            int index = listBox1.FindStringExact(searchText);

            if (index != ListBox.NoMatches)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                listBox1.ClearSelected();
            }

        }


    }
}
