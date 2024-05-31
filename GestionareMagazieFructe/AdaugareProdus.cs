using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionareMagazieFructe
{
    public partial class AdaugareProdus : Form
    {
        public AdaugareProdus()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (txtNumarPaleti.Text != string.Empty && txtTipProdus.Text != string.Empty && txtRaion.Text != string.Empty)
            {
                string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
                SqlConnection conn = new SqlConnection(connect);
                conn.Open();
                string date = "insert into Produse ([numar_paleti],[tip_produs],[raion]) values (@nrp , @tp , @r)";
                SqlCommand sc = new SqlCommand(date, conn);
                sc.Parameters.AddWithValue("@nrp", Convert.ToInt16(txtNumarPaleti.Text));
                sc.Parameters.AddWithValue("@tp",txtTipProdus.Text);
                sc.Parameters.AddWithValue("@r",txtRaion.Text);
                sc.ExecuteNonQuery();
                conn.Close();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Completarea tuturor campurilor este obligatorie!");
        }

        private void AdaugareProdus_Load(object sender, EventArgs e)
        {

        }
    }
}
