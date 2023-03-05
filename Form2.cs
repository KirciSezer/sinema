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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
        int fiyat = 0;
        int mısır=8;
        int kola = 5;
        int mısırkola = 10;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            if (comboBox1.SelectedItem.ToString()=="Organize İşler")
            {
                fiyat = 15;
                textBox1.Text = fiyat.ToString();

            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem.ToString() == "mısır")
            {
                int odeme = fiyat * sayac;
                odeme += mısır;
                listBox1.Items.Add("Son Fiyat :" + odeme);
            }
            else if (comboBox4.SelectedItem.ToString() == "kola")
            {
                int odeme = fiyat * sayac;
                odeme += kola;
                listBox1.Items.Add("Son Fiyat :" + odeme);
            }
            else if (comboBox4.SelectedItem.ToString() == "mısır+kola")
            {
                int odeme = fiyat * sayac;
                odeme += mısırkola;
                listBox1.Items.Add("Son Fiyat :" + odeme);
            }


        }
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkRed;
            button2.Enabled = false;
            listBox1.Items.Add("Koltuk 1 seçildi");
            sayac++;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.DarkRed;
            button3.Enabled = false;
            listBox1.Items.Add("Koltuk 2 seçildi");
            sayac++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.DarkRed;
            button4.Enabled = false;
            listBox1.Items.Add("Koltuk 3 seçildi");
            sayac++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.DarkRed;
            button5.Enabled = false;
            listBox1.Items.Add("Koltuk 4 seçildi");
            sayac++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.DarkRed;
            button6.Enabled = false;
            listBox1.Items.Add("Koltuk 5 seçildi");
            sayac++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.DarkRed;
            button7.Enabled = false;
            listBox1.Items.Add("Koltuk 7 seçildi");
            sayac++;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            label7.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            label6.Visible = true;
            comboBox3.Visible = true;
          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem.ToString()=="Evet")
            {
                comboBox4.Visible = true;
                label7.Visible = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox4.SelectedItem.ToString()=="mısır")
            {
                int odeme = fiyat * sayac;
                odeme += mısır;
             
            }
            else if(comboBox4.SelectedItem.ToString()=="kola")
            {
                int odeme = fiyat * sayac;
                odeme += kola;
             
            }
            else if(comboBox4.SelectedItem.ToString() == "mısır+kola")
            {
                int odeme = fiyat * sayac;
                odeme += mısırkola;
                
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = sayac;
            int odeme = fiyat * sayac;
            //MessageBox.Show("Ödemeniz Gereken Tutar : "+odeme);
            listBox1.Items.Add("Film : " + comboBox1.SelectedItem);
            listBox1.Items.Add("Seans : " + comboBox2.SelectedItem);
            listBox1.Items.Add("Bilet Fiyatı : " + textBox1.Text);
            listBox1.Items.Add("Bilet Adet : " + numericUpDown1.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
