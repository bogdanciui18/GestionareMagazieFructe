using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareMagazieFructe
{
    public partial class AdaugareInfoProdus : Form
    {
        string tip_produs_citit;
        public AdaugareInfoProdus(string tip_produs)
        {
            this.tip_produs_citit = tip_produs;
            InitializeComponent();
        }

        private void AdaugareInfoProdus_Load(object sender, EventArgs e)
        {
            txtTipProdus.Text = tip_produs_citit.ToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtTipProdus.Text != string.Empty && txtDataCulegerii.Text != string.Empty && txtCalitate.Text != string.Empty && txtPret.Text != string.Empty)
            {
                string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into InfoProduse ([tip_produs],[data_culegerii],[calitate],[nr_minim]) values (@tp , @dc , @c , @nm)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@tp", txtTipProdus.Text);
                sc.Parameters.AddWithValue("@dc", txtDataCulegerii.Text);
                sc.Parameters.AddWithValue("@c", txtCalitate.Text);
                sc.Parameters.AddWithValue("@nm", txtPret.Text);
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
