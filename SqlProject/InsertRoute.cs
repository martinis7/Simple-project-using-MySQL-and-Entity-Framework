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
using System.Configuration;

namespace SqlProject
{
    public partial class InsertRoute : Form
    {
        public InsertRoute()
        {
            InitializeComponent();
        }

        private void InsertRoute_Load(object sender, EventArgs e)
        {
            using (
                SqlConnection con =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                // visu stoteliu pavadinimai
                using (SqlCommand cmd = new SqlCommand("SELECT Name FROM Stop", con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxStartStop.Items.Add(reader[0]);
                            comboBoxEndStop.Items.Add(reader[0]);
                            checkedListBoxStops.Items.Add(reader[0]);
                        }
                    }
                    // pirminis autobuso raktas ir autobuso gamintojas
                    cmd.CommandText = "SELECT [Bus Id] FROM Bus WHERE Route is NULL";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkedListBoxBuses.Items.Add(reader[0]);
                        }
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool parseCondition = true;
            int routeId;

            if (!int.TryParse(txtRouteId.Text, out routeId) || CheckForDuplicate(routeId))
            {
                txtRouteId.BackColor = Color.Red;
                parseCondition = false;
            }

            if (comboBoxStartStop.SelectedIndex < 0)
            {
                comboBoxStartStop.BackColor = Color.Red;
                parseCondition = false;
            }

            if (comboBoxEndStop.SelectedIndex < 0)
            {
                comboBoxEndStop.BackColor = Color.Red;
                parseCondition = false;
            }

            if (parseCondition)
            {
                //prideti i route lentele
                using (
                    SqlConnection con =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                {
                    SqlCommand command = new SqlCommand();
                    command.Parameters.AddWithValue("@RouteId", routeId);
                    command.Parameters.AddWithValue("@StartStop", comboBoxStartStop.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@EndStop", comboBoxEndStop.SelectedIndex + 1);

                    command.CommandText = "INSERT INTO Route VALUES (@RouteId, @StartStop, @EndStop)";

                    command.Connection = con;
                    con.Open();
                    command.ExecuteNonQuery();

                    foreach (var stop in checkedListBoxStops.CheckedIndices)
                    {
                        command.CommandText = "INSERT INTO Stops VALUES (" + ((int)stop + 1) + ", @RouteId)";
                        command.ExecuteNonQuery();
                    }

                    foreach (var bus in checkedListBoxBuses.CheckedItems)
                    {
                        command.CommandText = "UPDATE Bus SET Route = @RouteId WHERE [Bus Id] = " + bus;
                        command.ExecuteNonQuery();
                    }
                }

                Close();
            }
      }

        private bool CheckForDuplicate(int routeId)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand("SELECT [Route Id] FROM Route", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (routeId == (int)reader[0]) return true;
                        }
                    }
                }
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
