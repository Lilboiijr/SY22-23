using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amt;
            double.TryParse(convertTextbox.Text, out amt);
            pesoTextbox.Text = (amt * 0.050).ToString("c2");
            eurotextbox.Text = (amt * 1.00).ToString("c2");
           dollartextbox.Text = (amt * 1.00).ToString("c2");
            poundtextbox.Text = (amt * 0.85).ToString("c2");
            singatextbox.Text = (amt * 0.72).ToString("c2");
           canatextbox.Text = (amt * 1.30).ToString("c2");
        }
    }
}
