using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
            // DragDrop olaylarını bağla
            listBox1.DragEnter += listBox1_DragEnter;
            listBox2.DragEnter += listBox2_DragEnter;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            



        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

            // Sürükleme işlemi başlatılır
            if (listBox1.SelectedItem != null)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Copy);
            }

        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            // Sürüklenen öğenin verisi alınır ve hedef listbox'a eklenir
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string item = (string)e.Data.GetData(DataFormats.StringFormat);
                listBox2.Items.Add(item);
            }

        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            // Sürüklenen öğe bir dize ise kabul et
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }


        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Sürüklenen öğe bir dize ise kabul et
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            // Sürüklenen öğenin verisi alınır ve hedef listbox'a eklenir
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string item = (string)e.Data.GetData(DataFormats.StringFormat);
                listBox1.Items.Add(item);
            }

        }
    }
}
