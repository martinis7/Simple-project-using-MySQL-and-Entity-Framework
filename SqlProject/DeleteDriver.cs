using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class DeleteDriver : Form
    {
        public DeleteDriver()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    if (comboBoxDriverId.SelectedItem != null) 
                    {
                    cmd.Parameters.AddWithValue("@DriverId", comboBoxDriverId.SelectedItem);
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM Driver WHERE Id = @DriverId";
                    con.Open();
                    cmd.ExecuteNonQuery();
                    }
                }
                Close();
        }

        private void DeleteDriver_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT Id FROM Driver", con))
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDriverId.Items.Add(reader["Id"]);
                        }
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
