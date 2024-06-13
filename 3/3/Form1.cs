using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;


            random = new Random();


            Load += (s, e) => timer1.Start();
        }


        private readonly Timer timer;
        private readonly Random random;


        private void timer1_Tick(object sender, EventArgs e)
        {
            int index = random.Next(ımageList1.Images.Count);
            button1.Image = ımageList1.Images[index];

        }


    }
}
