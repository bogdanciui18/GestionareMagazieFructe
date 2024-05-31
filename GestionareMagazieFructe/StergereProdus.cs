using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionareMagazieFructe
{
    public partial class Stergere : Form
    {
        private const string connectionString = @"Data Source=BOGDAN-PC\SQLEXPRESS;Initial Catalog=ProduseMagazie; Integrated Security=True";

        public Stergere()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            string country = txtTara.Text.Trim();

            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Introduceți un produs valid.");
                return;
            }

            DialogResult result = MessageBox.Show("Sigur doriți să ștergeți Produsul? " , "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                string deleteProduseQuery = "DELETE FROM Produse WHERE tip_produs = @Country";
                                SqlCommand deleteFlightsCommand = new SqlCommand(deleteProduseQuery, connection, transaction);
                                deleteFlightsCommand.Parameters.AddWithValue("@Country", country);
                                int flightsDeleted = deleteFlightsCommand.ExecuteNonQuery();

                                transaction.Commit();

    
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("A apărut o eroare în timpul ștergerii: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }
        }

        private void Stergere_Load(object sender, EventArgs e)
        {

        }
    }
}