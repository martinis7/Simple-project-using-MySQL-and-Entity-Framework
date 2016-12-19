using System;
using System.ComponentModel;
using System.Data.Entity;
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

            busBindingSource.DataSource =
                _context.Buses.Local.ToBindingList();
        }

        private void busBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
    
            _context.SaveChanges();
            
            busDataGridView.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }
    }
}
