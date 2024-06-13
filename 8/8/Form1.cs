using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // RichTextBox'teki metni dosyaya kaydet
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Metin dosyası başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // RichTextBox'teki metni farklı bir dosyaya kaydet
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Metin dosyası farklı bir adla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Açılacak dosyanın adını ve yolunu al
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Dosyadaki metni RichTextBox'e yükle
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Dosya başarıyla açıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya açılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
