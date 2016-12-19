using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class SqlManager : Form
    {
        public SqlManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UpdateComboBox();
            TablesList.Items.Add("Driver");
            TablesList.Items.Add("Bus");
            TablesList.Items.Add("Driving");
        }

        //private void UpdateComboBox()
        //{
        //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand("SELECT table_name FROM information_schema.tables", con))
        //        {
        //            con.Open();
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    TablesList.Items.Add(reader["table_name"]);
        //                }
        //            }
        //        }
        //    }
        //}

        private void TablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablesList.SelectedItem != null)
            {
                DataTable dt = new DataTable();
                if (TablesList.SelectedItem.Equals("Driver"))
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT Firstname, Lastname, Phone FROM Driver", con);
                        da.Fill(dt);
                    }
                }
                if (TablesList.SelectedItem.Equals("Bus"))
                {
                    using (
                        SqlConnection con =
                            new SqlConnection(
                                ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT Make, Model, Capacity, Route FROM Bus", con);
                        da.Fill(dt);
                    }
                }
                if (TablesList.SelectedItem.Equals("Driving"))
                {
                    using (
                       SqlConnection con =
                           new SqlConnection(
                               ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT A.Firstname, A.Lastname, B.[Start time], B.[End time] FROM Driver A, Driving B WHERE B.Id = A.Id ", con);
                        da.Fill(dt);
                    }
                }
                dataGridView.DataSource = dt;
                dataGridView.ResetBindings();
            }
        }

        //private void ShowTableInfo(string tableName)
        //{
        //    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + tableName, con);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView.DataSource = dt;
        //        dataGridView.ResetBindings();
        //    }
        //}

        private void btnAction_Click(object sender, EventArgs e)
        {
            CurrentStop cs = new CurrentStop();
            DataTable data = cs.BusesInAction_Load();
            dataGridView.DataSource = data;
            dataGridView.ResetBindings();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertDriver form = new InsertDriver();
            form.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDriver form = new UpdateDriver();
            form.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDriver form = new DeleteDriver();
            form.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Driving form = new Driving();
            form.ShowDialog();
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertRoute form = new InsertRoute();
            form.ShowDialog();
        }
    }
}
