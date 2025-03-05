using System;
using System.Windows.Forms;

namespace tp_Modul3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string namaPraktikan = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(namaPraktikan)) 
            {
                labelOutput.Text = "Halo " + namaPraktikan; 
            }
            else
            {
                labelOutput.Text = "Silakan masukkan nama praktikan."; 
            }
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
