using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class UpdateDriver : Form
    {

        public UpdateDriver()
        {
            InitializeComponent();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int driverId;
            int phoneNumber = 0;
            bool parseCondition = true;

            if (!int.TryParse(DriverIdtxt.Text, out driverId))
            {
                DriverIdtxt.BackColor = Color.Red;
                parseCondition = false;
            }

            if (string.IsNullOrEmpty(FirstNametxt.Text))
            {
                FirstNametxt.BackColor = Color.Red;
                parseCondition = false;
            }
            if (string.IsNullOrEmpty(LastNametxt.Text))
            {
                LastNametxt.BackColor = Color.Red;
                parseCondition = false;
            }

            string firstName = FirstNametxt.Text;
            string lastName = LastNametxt.Text;

            if (!string.IsNullOrEmpty(PhoneNumbertxt.Text) && !int.TryParse(PhoneNumbertxt.Text, out phoneNumber))
            {
                PhoneNumbertxt.BackColor = Color.Red;
                parseCondition = false;
            }
            if (parseCondition)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Parameters.AddWithValue("@CurrentDriverId", DriverIdComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DriverId", driverId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@Lastname", lastName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    if (phoneNumber == 0)
                    {
                        command.CommandText = "UPDATE Driver SET Id = @DriverId, First name = @FirstName, Last name = @LastName, Phone number = null WHERE Id = @CurrentDriverId";
                    }
                    else
                    {
                        command.CommandText = "UPDATE Driver SET Id = @DriverId, Firstname = @FirstName, Lastname = @LastName, Phone = @PhoneNumber WHERE Id = @CurrentDriverId";
                    }
                    command.Connection = con;
                    con.Open();
                    command.ExecuteNonQuery();
                }
                Close();
            }

        }

        private void UpdateDriver_Load(object sender, EventArgs e)
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
                            DriverIdComboBox.Items.Add(reader["Id"]);
                        }
                    }
                }
            }
        }

        private void DriverIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = DriverIdComboBox.Text;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Driver WHERE Id = @Id", con))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        DriverIdtxt.Text = reader["Id"].ToString();
                        FirstNametxt.Text = reader["Firstname"].ToString();
                        LastNametxt.Text = reader["Lastname"].ToString();
                        PhoneNumbertxt.Text = reader["Phone"].ToString();
                    }
                }
            }
        }
    }
}
