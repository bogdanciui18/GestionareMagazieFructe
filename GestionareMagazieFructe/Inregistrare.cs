using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionareMagazieFructe
{
    public partial class Inregistrare : Form
    {
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            progressBar1.Value -= 1;
            progressBar1.Value += 1;
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Inregistrarea a reusit!");
                Application.Restart();

            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            timer1.Start();
            using (StreamWriter w = File.AppendText("magazionerii.txt"))
            {
                w.WriteLine(txtUtilizator.Text + ","+txtParola.Text);
            }
        }

    }
}
