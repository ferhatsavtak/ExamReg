using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        
        {
            InitializeComponent();
           
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bolum ;
            bolum = comboBox1.SelectedItem.ToString();
            if (bolum == "Mekatronik Muhendisligi")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Matematik");
                listBox1.Items.Add("Fizik");
                listBox1.Items.Add("Kimya");
                listBox1.Items.Add("Teknik Resim");
                listBox1.Items.Add("Mekatroniğe Mühendisliğine Giriş");
                listBox1.Items.Add("Bilgisayar Programlama I");
                

            }
            else if (bolum == "Makine Muhendisligi")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Matematik");
                listBox1.Items.Add("Fizik");
                listBox1.Items.Add("Kimya");
                listBox1.Items.Add("Teknik Resim");
                listBox1.Items.Add("Makine Mühendisliğine Giriş");
            }
            else if (bolum== "Elektrik Elektronik Muhendisligi")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Matematik");
                listBox1.Items.Add("Fizik");
                listBox1.Items.Add("Kimya");
                listBox1.Items.Add("Elektronik I");
                listBox1.Items.Add("Elektrik Elektronik Mühendisliğine  Giriş");
            }
            else if (bolum == "Tip")
            {
                listBox1.Items.Clear();
                
                listBox1.Items.Add("Temel Bilimlere Giriş I");
                listBox1.Items.Add("Hücrenin Moleküler Yapısı ve Genetik");
                listBox1.Items.Add("Doku ve Hareket Sistemi   I ");
                listBox1.Items.Add("Hareket Sistemi  I");
                listBox1.Items.Add("Hemopoetik, Dolaşım ve Solunum Sistemleri");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string b;
            string ad=textBox1.Text;
            string soyad=textBox2.Text;
            if (radioButton1.Checked == true)
            {
                 b = "Bay";

            }
            else
            {
                b = "Bayan";
            }
           
            double vize =Convert.ToInt32( textBox3.Text);
            double final = Convert.ToInt32(textBox4.Text);
            double ortalama= vize*0.4 + final*0.6;
            
            string ne = listBox1.SelectedItem.ToString();
            string gecis;
            if (ortalama < 60 | final<50)
            {
                 gecis = "Kalmıştır";
            }
            else
            {
                gecis = "Geçmiştir";
            }
            listBox2.Items.Add(comboBox1.SelectedItem.ToString() + " Bölümünde Okumakta Olan " + b + " " + ad + " " + soyad + " Not Ortalaması " + ortalama + " Olan " + ne + " Dersinden  " + gecis);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
      
    }
}
