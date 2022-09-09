using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Main : Form
    {
        private readonly CarRentalEntities _db;
        public Main()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addCarRentalRecord = new AddCarRentalRecord();
            addCarRentalRecord.MdiParent = this;
            addCarRentalRecord.Show();
            addCarRentalRecord.WindowState = FormWindowState.Maximized;
        }
        private void listingRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageVehicleListing = new ManageVehicleListing();
            manageVehicleListing.MdiParent = this;
            manageVehicleListing.Show();
            manageVehicleListing.WindowState = FormWindowState.Maximized;
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }
    }
}
