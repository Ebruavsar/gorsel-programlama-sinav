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
    git clone https://github.com/kullaniciadi/projeadi.git
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
    // Kod burada yer alacak
    ```

### 3. İmagelist ve Timer Kullanarak Buton İkonu Değiştirme
- **Açıklama:** Bir butonun ikonunu 3 saniyede bir rastgele değiştirir.
- **Kod:**
    ```csharp
    // Kod burada yer alacak
    ```

### 4. Sürükle Bırak Yöntemi ile Listboxlar Arası Veri Aktarma
- **Açıklama:** Listbox1’de yer alan kişiler listesinden istenilen kişi isminin sürükle bırak yöntemi ile Listbox2’ye aktarılmasını sağlar.
- **Kod:**
    ```csharp
    // Kod burada yer alacak
    ```




