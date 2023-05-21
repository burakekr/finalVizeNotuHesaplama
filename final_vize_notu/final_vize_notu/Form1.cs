using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_vize_notu
{
    public partial class Form1 : Form
    {
        string adsoyad;
        int vize, final,vizeSonuc,finalSonuc,sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adsoyad = textBox1.Text;
            vize = Convert.ToInt32(textBox2.Text);
            final = Convert.ToInt32(textBox3.Text);
            if (vize>100 || final>100)
            {
                MessageBox.Show("Geçerli Sayı Giriniz");
            }
            else
            {
                vizeSonuc = (vize * 40) / 100;
                finalSonuc = (final * 60) / 100;
                sonuc = vizeSonuc + finalSonuc;

                if (sonuc > 45)
                {
                    listBox1.Items.Add(" " + adsoyad + " = " + sonuc);
                }
                else
                {
                    listBox2.Items.Add(" " + adsoyad + " = " + sonuc);
                }
            }
            
        }
    }
}
