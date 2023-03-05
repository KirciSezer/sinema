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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aksiyonFilmleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();
        }

        private void bilimKurguFilmleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 git = new Form3();
            git.Show();
            this.Hide();
        }
    }
}
