using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
            label4.Visible = false;
            textBox3.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="evet")
            {
                int odeme = fiyat * adet;
                odeme-= 3;
               
                label4.Visible = true;
                textBox3.Visible = true;
            
            }
        }
        int adet = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkRed;
            button3.Enabled = false;
            listBox1.Items.Add("Koltuk 1 seçildi");
            adet++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkRed;
            button4.Enabled = false;
            listBox1.Items.Add("Koltuk 2 seçildi");
            adet++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkRed;
            button5.Enabled = false;
            listBox1.Items.Add("Koltuk 3 seçildi");
            adet++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkRed;
            button6.Enabled = false;
            listBox1.Items.Add("Koltuk 4 seçildi");
            adet++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkRed;
            button7.Enabled = false;
            listBox1.Items.Add("Koltuk 5 seçildi");
            adet++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.DarkRed;
            button8.Enabled = false;
            listBox1.Items.Add("Koltuk 6 seçildi");
            adet++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.DarkRed;
            button9.Enabled = false;
            listBox1.Items.Add("Koltuk 7 seçildi");
            adet++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.DarkRed;
            button10.Enabled = false;
            listBox1.Items.Add("Koltuk 8 seçildi");
            adet++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.DarkRed;
            button11.Enabled = false;
            listBox1.Items.Add("Koltuk 9 seçildi");
            adet++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.DarkRed;
            button12.Enabled = false;
            listBox1.Items.Add("Koltuk 10 seçildi");
            adet++;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.DarkRed;
            button13.Enabled = false;
            listBox1.Items.Add("Koltuk 11 seçildi");
            adet++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.DarkRed;
            button14.Enabled = false;
            listBox1.Items.Add("Koltuk 12 seçildi");
            adet++;
        }
        int fiyat = 0;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Captain Marvel")
            {   fiyat = 18;
                textBox3.Text = fiyat.ToString();
                int odeme = fiyat * adet;
                
  
            }
            else if(comboBox2.SelectedItem.ToString()=="Captain America")
            {
                fiyat = 20;
                textBox3.Text = fiyat.ToString();
                int odeme = fiyat * adet;            
               
            }
            else if(comboBox2.SelectedItem.ToString()=="Avengers End Game")
            {
                fiyat = 25;                
                textBox3.Text = fiyat.ToString();
                int odeme = fiyat * adet;   
            }
        }
        int mısır = 8;
        int cips = 6;
        int cikolata = 4;
        int kola = 4;
        int icetea = 4;
        int gazoz = 7;
       
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int odeme = fiyat * adet;
            odeme -= 3;
            odeme = odeme + 5;
            if (comboBox3.SelectedItem.ToString() == "evet")
            {
           
                if (radioButton1.Checked == true)
                {
                    odeme += mısır; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);

                }
                if (radioButton2.Checked == true)
                {
                    odeme += cips; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton3.Checked == true)
                {
                    odeme += cikolata; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton4.Checked == true)
                {
                    odeme += icetea; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton5.Checked == true)
                {
                    odeme += kola; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton6.Checked == true)
                {
                    odeme += gazoz; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
               }
            
            else if(comboBox3.SelectedItem.ToString()=="hayır")
            {
               
            }
        }
      
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //if(radioButton1.Checked==true)
            //{
            //    odeme += mısır;
            //}
            //if(radioButton2.Checked==true)
            //{
            //    fiyat += cips;
            //}
            //if (radioButton3.Checked == true)
            //{
            //    fiyat += cikolata;
            //}
            //if (radioButton4.Checked == true)
            //{
            //    fiyat += icetea;
            //}
            //if (radioButton5.Checked == true)
            //{
            //    fiyat += kola;
            //}
            //if (radioButton6.Checked == true)
            //{
            //    fiyat += gazoz;
            //}
          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = adet;
            string ad = Convert.ToString(textBox1.Text);
            string soyad = Convert.ToString(textBox2.Text);
            listBox1.Items.Add(comboBox1.SelectedItem);
            listBox1.Items.Add("Seçtiğimiz film :" + comboBox2.SelectedItem);
            listBox1.Items.Add("Bilet fiyatı :" + textBox3.Text);
            listBox1.Items.Add("Adet :" + numericUpDown1.Value);
            listBox1.Items.Add("3D cevabı :" + comboBox3.SelectedItem);
            int odeme = fiyat * adet;
            odeme -= 3;
            odeme = odeme + 5;
            if (comboBox3.SelectedItem.ToString() == "evet")
            {

                if (radioButton1.Checked == true)
                {
                    odeme += mısır; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);

                }
                if (radioButton2.Checked == true)
                {
                    odeme += cips; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton3.Checked == true)
                {
                    odeme += cikolata; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton4.Checked == true)
                {
                    odeme += icetea; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton5.Checked == true)
                {
                    odeme += kola; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
                if (radioButton6.Checked == true)
                {
                    odeme += gazoz; listBox1.Items.Add("Ödemeniz gereken fiyat : " + odeme);
                }
            }

        }
    }
}
