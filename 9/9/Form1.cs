using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] notlar = new double[5, 2];

            for (int i = 0; i < 5; i++)
            {
                notlar[i, 0] = Convert.ToDouble(InputBox($"Öğrenci {i + 1} Vize Notu: (0-100)"));
                notlar[i, 1] = Convert.ToDouble(InputBox($"Öğrenci {i + 1} Final Notu: (0-100)"));
            }
            string sonuc = "";
            for (int i = 0; i < 5; i++)
            {
                double vize = notlar[i, 0];
                double final = notlar[i, 1];

                // Vize ve final notlarını 100'den büyük olamayacak şekilde düzenle
                vize = Math.Min(vize, 100);
                final = Math.Min(final, 100);

                double ortalama = (vize + final) / 2;

                sonuc += $"Öğrenci {i + 1} Ortalama: {ortalama}\n";

                if (ortalama >= 70)
                {
                    sonuc += "Geçti\n\n";
                }
                else
                {
                    sonuc += "Kaldı\n\n";
                }
            }

            MessageBox.Show(sonuc, "Sonuçlar");

        }
        private string InputBox(string girdiler)
        {
            string input = Interaction.InputBox(girdiler, "Not Girişi");
            double not;
            if (!double.TryParse(input, out not) || not < 0 || not > 100)
            {
                MessageBox.Show("Geçersiz not girişi! Lütfen 0 ile 100 arasında bir sayı girin.", "Hata");
                return InputBox(girdiler); // Hatalı giriş olduğunda tekrar giriş iste
            }
            return input;

        }
    }
}
