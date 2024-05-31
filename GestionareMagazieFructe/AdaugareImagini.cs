using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareMagazieFructe
{
    public partial class AdaugareImagini : Form
    {
        string tip_produs_citit;
        public AdaugareImagini(string tip_produs)
        {
            this.tip_produs_citit = tip_produs;
            InitializeComponent();
        }

        private void AdaugareImagini_Load(object sender, EventArgs e)
        {
            txtTipProdus.Text = tip_produs_citit.ToString();
        }

        private void btnImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtImagine.Text = Path.GetFileName(dlg.FileName);
            }
        }

        private void btnAdaugaImagine_Click(object sender, EventArgs e)
        {
            if (txtImagine.Text != string.Empty)
            {
                string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into ImaginiProduse ([tip_produs],[cale_imagine]) values (@tp , @ci)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@tp", txtTipProdus.Text);
                sc.Parameters.AddWithValue("@ci", txtImagine.Text);
                sc.ExecuteNonQuery();
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Completarea tuturor campurilor este obligatorie!");
        }
    }
}
