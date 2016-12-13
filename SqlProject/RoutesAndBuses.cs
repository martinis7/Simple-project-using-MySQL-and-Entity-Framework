using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlProject
{
    public partial class RoutesAndBuses : Form
    {
        private RoutesDBContext _context;

        public RoutesAndBuses()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new RoutesDBContext();

            _context.Routes.Load();

            this.routeBindingSource.DataSource =
                _context.Routes.Local.ToBindingList();

            }

        private void routeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            foreach (var bus in _context.Buses.Local.ToList())
            {
                if (bus.Route1 == null)
                {
                    _context.Buses.Remove(bus);
                }
            }

            this._context.SaveChanges();

            this.routeDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }
    }
}
