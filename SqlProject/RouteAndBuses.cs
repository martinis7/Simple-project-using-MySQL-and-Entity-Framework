using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class RouteAndBuses : Form
    {
        public RouteAndBuses()
        {
            InitializeComponent();
        }

        private void RouteAndBuses_Load(object sender, EventArgs e)
        {
            using (Public_transport_Entities context = new Public_transport_Entities())
            {
                Route route = context.Routes.FirstOrDefault(r => r.Route_Id == 2);
                if (route != null)
                {
                    List<Bus> buses = route.Buses.ToList();
                    dataGridView1.DataSource = buses;
                    dataGridView1.ResetBindings();
                }
            }

        }
    }
}
