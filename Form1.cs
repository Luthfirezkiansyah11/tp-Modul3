using System;
using System.Windows.Forms;

namespace tp_Modul3
{
    public partial class Form1 : Form
    {
        // Constructor untuk Form1
        public Form1()
        {
            InitializeComponent();
        }

        // Event untuk Button click
        private void button1_Click(object sender, EventArgs e)
        {
            string namaPraktikan = textBox1.Text.Trim();

            // Tampilkan output di Label
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
