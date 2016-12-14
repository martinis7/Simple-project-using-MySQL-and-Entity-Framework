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
    public partial class Driving : Form
    {
        private DrivingDBContext _context;

        public Driving()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DrivingDBContext();

            _context.Buses.Load();

            this.busBindingSource.DataSource =
                _context.Buses.Local.ToBindingList();
        }

        private void busBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this._context.SaveChanges();

            this.busDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._context.Dispose();
        }
    }
}
