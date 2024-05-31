using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionareMagazieFructe
{
    public partial class VizualizareProduse : Form
    {
        string tip_produs_citit;
        public VizualizareProduse(string tip_produs)
        {
            this.tip_produs_citit = tip_produs;
            InitializeComponent();
        }

        private void VizualizareProduse_Load(object sender, EventArgs e)
        {
            txtTipProdus.Text = tip_produs_citit.ToString();

            string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();

            string tabel_date = "select * from Produse where tip_produs = '" + txtTipProdus.Text + "'";
            SqlCommand sc = new SqlCommand(tabel_date, conn);
            SqlDataReader dr = sc.ExecuteReader();
            if (dr.Read())
            {
                txtNumarPaleti.Text = dr["numar_paleti"].ToString();
                txtRaion.Text = dr["raion"].ToString();
            }
            conn.Close();

            conn.Open();
            tabel_date = "select * from InfoProduse where tip_produs = '" + txtTipProdus.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(tabel_date, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "InfoProduse");
            dGWInfoProd.DataSource = ds.Tables["InfoProduse"].DefaultView;

            conn.Close();

            AfisareImagini();
        }

        private void AfisareImagini()
        {
            PictureBox pb;
            int index = 0;

            fLPInformatii.Controls.Clear();
            string connect = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";
            SqlConnection conn = new SqlConnection(connect);
            conn.Open();
           string tabel_date = "select * from ImaginiProduse where tip_produs = '" + txtTipProdus.Text + "'";

            SqlCommand sc = new SqlCommand(tabel_date, conn);
            SqlDataReader dr = sc.ExecuteReader();
            while (dr.Read())
            {
                string poza = dr["cale_imagine"].ToString();
                string cale_poza = @"C:\poze\" + poza;
                pb = new PictureBox();
                pb.Name="Picture" + index.ToString();
                pb.SetBounds(0,0,90,70);
                pb.BackColor= Color.Black;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image=Bitmap.FromFile(cale_poza);
                pb.Tag = index++;
                fLPInformatii.Controls.Add(pb);
                pb.Click += Pb_Click;
            }
            conn.Close();
            sc.Dispose();
            dr.Close();

        }

        private void Pb_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pBoxPoze.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxPoze.Image = pic.Image;
            pic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
