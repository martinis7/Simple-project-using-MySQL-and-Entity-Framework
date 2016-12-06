using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class DeleteDriver : Form
    {
        public DeleteDriver()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int driverId;
            bool parseCondition = true;

            if (!int.TryParse(DriverIdTextBox.Text, out driverId))
            {
                DriverIdTextBox.BackColor = Color.Red;
                parseCondition = false;
            }

            if (parseCondition)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@DriverId", driverId);
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM Driver WHERE Id = @DriverId";
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                Close();
            }
        }
    }
}
