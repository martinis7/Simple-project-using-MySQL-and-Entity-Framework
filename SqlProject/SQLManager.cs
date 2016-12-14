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
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT table_name FROM information_schema.tables", con))
                {
                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TablesList.Items.Add(reader["table_name"]);
                        }
                    }
                }
            }
        }

        private void TablesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TablesList.SelectedItem != null)
            {
                string name = TablesList.SelectedItem.ToString();
                ShowTableInfo(name);
            }
        }

        private void ShowTableInfo(string tableName)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PublicTransportCS"].ConnectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + tableName, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView.DataSource = dt;
                dataGridView.ResetBindings();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertDriver form = new InsertDriver();
            form.ShowDialog();
            UpdateTableAutomatically();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteDriver form = new DeleteDriver();
            form.ShowDialog();
            UpdateTableAutomatically();
        }

        private void UpdateTableAutomatically()
        {
            if (TablesList.SelectedItem != null)
            {
                string tableName = TablesList.SelectedItem.ToString();
                if (tableName.Equals("Driver"))
                {
                    ShowTableInfo(tableName);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
           UpdateDriver form = new UpdateDriver();
           form.ShowDialog();
           UpdateTableAutomatically();
        }

        private void btnInsertRoute_Click(object sender, EventArgs e)
        {
            InsertRoute form = new InsertRoute();
            form.ShowDialog();
        }
    }
}
