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
    public partial class ProduseMagazie : Form
    {
        public ProduseMagazie()
        {
            InitializeComponent();
        }

        private void ProduseMagazie_Load(object sender, EventArgs e)
        {
            string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string tabel_date = "select * from Produse";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, conn);
            DataSet ds = new DataSet(); 
            da.Fill(ds,"Produse");
            dGWProduse.DataSource = ds.Tables["Produse"].DefaultView;
            conn.Close();
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
            string tabel_date = "select * from Produse WHERE tip_produs = '" + txtCautare.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Produse");
            dGWProduse.DataSource = ds.Tables["Produse"].DefaultView;
            conn.Close();
            da.Dispose();
            ds.Dispose();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            AdaugareProdus f = new AdaugareProdus();
            f.ShowDialog();
        }

        private void ProduseMagazie_Activated(object sender, EventArgs e)
        {
            this.ProduseMagazie_Load(sender, e); 
        }

        private void btnAdaugareInfo_Click(object sender, EventArgs e)
        {
            string tip_produs =dGWProduse.SelectedCells[0].Value.ToString();
            AdaugareInfoProdus f = new AdaugareInfoProdus(tip_produs);
            f.ShowDialog();
        }

        private void btnAdaugareImagini_Click(object sender, EventArgs e)
        {
            string tip_produs = dGWProduse.SelectedCells[0].Value.ToString();
            AdaugareImagini f = new AdaugareImagini(tip_produs);
            f.ShowDialog();
        }

        private void btnVizualizareProdus_Click(object sender, EventArgs e)
        {
            string tip_produs = dGWProduse.SelectedCells[0].Value.ToString();
            VizualizareProduse f = new VizualizareProduse(tip_produs);
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            using (Stergere stergereForm = new Stergere())
            {
                stergereForm.ShowDialog();
                //Application.Restart();
                ProduseMagazie_Load(sender, e);
            }
        }
    }
}
