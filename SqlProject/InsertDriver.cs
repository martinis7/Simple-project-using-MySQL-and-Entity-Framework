using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class InsertDriver : Form
    {
         
        public InsertDriver()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            int driverId;
            int phoneNumber = 0;
            bool parseCondition = true;

            if (!int.TryParse(IdTextBox.Text, out driverId) || CheckForDuplicate(driverId))
            {
                IdTextBox.BackColor = Color.Red;
                parseCondition = false;
            }

            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                FirstNameTextBox.BackColor = Color.Red;
                parseCondition = false;
            }
            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                LastNameTextBox.BackColor = Color.Red;
                parseCondition = false;
            }

            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;

            if (!string.IsNullOrEmpty(NumberTextBox.Text) && !int.TryParse(NumberTextBox.Text, out phoneNumber))
            {
                NumberTextBox.BackColor = Color.Red;
                parseCondition = false;
            }

            if (parseCondition)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Parameters.AddWithValue("@DriverId", driverId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@Lastname", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    if (phoneNumber == 0)
                    {
                        command.CommandText = "INSERT INTO Driver VALUES (@DriverId,@FirstName,@LastName, null)";
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Driver VALUES (@DriverId,@FirstName,@LastName,@PhoneNumber)";
                    }
                    command.Connection = con;
                    con.Open();
                    command.ExecuteNonQuery();
                }
                Close();
            }
        }

        private bool CheckForDuplicate(int driverId)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT Id FROM Driver", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (driverId == (int) reader[0]) return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
