# Görsel Programlama Vize Çalışmaları

Bu repository, Görsel Programlama dersi için hazırlanan sorularının çözümlerini içermektedir. Sorular, Windows Form uygulamaları olarak gerçekleştirilmiştir. Her bir sorunun çözüm kodlarına ve açıklamalarına buradan ulaşabilirsiniz.

## İçindekiler

1. [Sorular](#sorular)
2. [Nasıl Kullanılır](#nasıl-kullanılır)
3. [Soru Detayları ve Çözümler](#soru-detayları-ve-çözümler)

## Sorular

Aşağıda yer alan soruların puan dağılımları ve açıklamaları bulunmaktadır:

1. **Listbox içindeki değerin kontrolü ve seçimi** 
2. **Metin yazımı esnasında boşlukları sayma** 
3. **İmagelist ve timer kullanarak buton ikonu değiştirme** 
4. **Sürükle bırak yöntemi ile listboxlar arası veri aktarma** 
5. **Textbox kontrolü üzerinde çeşitli işlemler** 
6. **Panel ve RadioGroup kullanarak renk değiştirme uygulaması** 
7. **Düzen menüsü ile textbox yazı biçimini değiştirme** 
8. **RichTextBox içeriğini kaydetme** 
9. **Öğrenci not hesaplama ve geçme durumu kontrolü** 
10. **Buton koordinatları ve hareketi kontrol etme** 
11. **Kategori ekleme ve silme işlemleri** 
12. **Geometrik çizim ve serbest çizim uygulamaları** 

## Nasıl Kullanılır

Bu projeyi kendi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1. **Repository'yi klonlayın:**
    ```sh
    git clone https://github.com/Ebruavsar/gorsel-programlama-sinav.git
    ```
2. **Visual Studio veya başka bir IDE kullanarak projeyi açın.**
3. **Her bir sorunun çözümü için ilgili form dosyasını açın ve çalıştırın.**

## Soru Detayları ve Çözümler

### 1. Listbox İçindeki Değerin Kontrolü ve Seçimi
- **Açıklama:** TextBox kontrolüne girilen değerin ListBox içinde olup olmadığını kontrol eder. Eğer değer ListBox içinde bulunuyorsa, bu değerler seçili hale getirilir.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```

### 2. Metin Yazımı Esnasında Boşlukları Sayma
- **Açıklama:** Nokta işareti girilene kadar yazılan metindeki boşlukları sayar.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```

### 3. İmagelist ve Timer Kullanarak Buton İkonu Değiştirme
- **Açıklama:** Bir butonun ikonunu 3 saniyede bir rastgele değiştirir.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```

### 4. Sürükle Bırak Yöntemi ile Listboxlar Arası Veri Aktarma
- **Açıklama:** Listbox1’de yer alan kişiler listesinden istenilen kişi isminin sürükle bırak yöntemi ile Listbox2’ye aktarılmasını sağlar.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```
### 5. Textbox Kontrolü Üzerinde Çeşitli İşlemler
- **Açıklama:** Belirli tuş kombinasyonları ile textbox kontrolünde çeşitli işlemler gerçekleştirir.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```
  ### 6. Panel ve RadioGroup Kullanarak Renk Değiştirme Uygulaması
- **Açıklama:** Kullanıcı RadioGroup bileşenindeki seçeneklerden birini seçtikten sonra ScrollBar'ların değerlerini kullanarak panelin zemin rengini veya yazı rengini değiştirir.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```

### 7. Düzen Menüsü ile TextBox Yazı Biçimini Değiştirme
- **Açıklama:** Düzen menüsü altında belirtilen yapıya göre textbox’da yer alan yazının biçimini değiştirir.
- **Kod:**
    ```csharp
  ﻿using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    
    namespace _7
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
    
            private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (kalınToolStripMenuItem.Checked)
                {
                    textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Bold);
                }
                else
                {
                    textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
                }
            }
    
            private void eğikToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (kalınToolStripMenuItem.Checked)
                {
                    textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
    
    
                }
                else
                {
                    textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
                }
            }
    
            private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (kalınToolStripMenuItem.Checked)
                {
                    textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
                }
                else
                {
                    textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);
                }
            }
        }
    }
    ```

### 8. RichTextBox İçeriğini Kaydetme
- **Açıklama:** RichTextBox içeriğini bir dosyaya kaydeder.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```

### 9. Öğrenci Not Hesaplama ve Geçme Durumu Kontrolü
- **Açıklama:** Öğrenci notlarını alarak ortalama hesaplar ve geçme durumunu belirler.
- **Kod:**
    ```csharp
    ﻿using System;
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
    ```

### 10. Buton Koordinatları ve Hareketi Kontrol Etme
- **Açıklama:** Belirli tuş kombinasyonları ile butonun koordinatlarını değiştirir.
- **Kod:**
    ```csharp
  ﻿using System;
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
    ```

### 11. Kategori Ekleme ve Silme İşlemleri
- **Açıklama:** Kategorileri ekleme ve silme işlemlerini gerçekleştirir.
- **Kod:**
    ```csharp
    ﻿using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    
    namespace _11
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
    
            private void button1_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Lütfen bir kategori adı girin.");
                    return;
                }
    
                if (radioButton1.Checked)
                {
                    // Kök düğüm olarak ekle
                    treeView1.Nodes.Add(textBox1.Text);
                }
                else if (radioButton2.Checked && treeView1.SelectedNode != null)
                {
                    // Seçili düğüm altında alt düğüm olarak ekle
                    treeView1.SelectedNode.Nodes.Add(textBox1.Text);
                    treeView1.SelectedNode.Expand();
                }
                else
                {
                    MessageBox.Show("Lütfen bir düğüm seçin veya kök düğüm olarak eklemek için seçeneği işaretleyin.");
                }
            }
    
            private void button2_Click(object sender, EventArgs e)
            {
                if (treeView1.SelectedNode != null)
                {
                    treeView1.SelectedNode.Remove();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek bir düğüm seçin.");
                }
            }
    
            private void button3_Click(object sender, EventArgs e)
            {
                treeView1.ExpandAll();
                
            }
        }
    }
    ```

### 12. Geometrik Çizim ve Serbest Çizim Uygulamaları
- **Açıklama:** Mouse hareketlerine ve click olaylarına göre çeşitli geometrik şekiller çizer.
- **Kod:**
    ```csharp
   ﻿using System;
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
    ```



