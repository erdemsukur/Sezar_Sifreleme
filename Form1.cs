using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sezarsifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int zaman = 5;
        class sifreleme
        {
            public static string sezar(string metin, int deger)
            {
                char[] karakter = metin.ToCharArray();
                for (int i = 0; i < karakter.Length; i++)
                {
                    char harf = karakter[i];
                    harf = (char)(harf + deger);

                    if (harf > 'z')
                    {
                        harf = (char)(harf - 26);
                    }
                    else if (harf < 'a')
                    {
                        harf = (char)(harf + 26);
                    }
                     if (char.IsWhiteSpace(karakter[i]))
                    {
                        harf = (char)(' ');
                     
                    }
                   
                    karakter[i] = harf;
                    
                }
                return new string(karakter);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string a = textBox1.Text;
            string aa = a.Trim();
            textBox2.Text =sifreleme.sezar(aa, 3); 
           
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            button1.Enabled = false;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string b = textBox2.Text;
            char[] karakter2 = b.ToCharArray();

            for (int j = 0; j < karakter2.Length; j++)
			{
			  textBox1.Text += Convert.ToChar(karakter2[j] - 3).ToString();
              if (karakter2[j]==' ')
              {
                  textBox1.Text += " ";
              }
			}
        
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            textBox2.ReadOnly = true;
         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            zaman--;
            label4.Text = zaman.ToString();
            if (zaman == 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                textBox2.Text = "";
                textBox1.Text = "";
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                label4.Text = string.Empty;
                timer1.Stop();
                zaman = 5;

                button1.Enabled = true;
                textBox1.Enabled = true;

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;

            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;

        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.WhiteSmoke;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
        }

        
    }
}

          

          



