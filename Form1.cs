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
            // Mengambil input dari TextBox dan memastikan tidak kosong
            string namaPraktikan = textBox1.Text.Trim(); // Trim untuk menghilangkan spasi kosong

            // Tampilkan output di Label
            if (!string.IsNullOrEmpty(namaPraktikan)) // Cek apakah input tidak kosong
            {
                labelOutput.Text = "Halo " + namaPraktikan;  // Menampilkan hasil output
            }
            else
            {
                labelOutput.Text = "Silakan masukkan nama praktikan.";  // Pesan jika input kosong
            }
        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}