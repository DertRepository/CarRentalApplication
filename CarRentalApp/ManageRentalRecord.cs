using ClosedXML;
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
    public partial class ManageRentalRecord : Form
    {
        private readonly CarRentalEntities _db;
        public ManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            var addManageRentalRecord = new AddCarRentalRecord();
            addManageRentalRecord.MdiParent = this.MdiParent;
            addManageRentalRecord.Show();
            addManageRentalRecord.WindowState = FormWindowState.Maximized;
        }

        private void btnEditRental_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRentalList.SelectedRows[0].Cells["ID"].Value;
                var rental = _db.CarRentals.FirstOrDefault(value => value.Id == id);

                var addCarRentalRecord = new AddCarRentalRecord(rental);
                addCarRentalRecord.MdiParent = this.MdiParent;
                addCarRentalRecord.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRental_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)gvRentalList.SelectedRows[0].Cells["ID"].Value;
                var rental = _db.CarRentals.FirstOrDefault(value => value.Id == id);
                _db.CarRentals.Remove(rental);
                _db.SaveChanges();
                MessageBox.Show("Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageRentalRecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateGrid()
        {
            var records = _db.CarRentals.Select(value => new
            {
                ID = value.Id,
                value.CustomerName,
                value.DateRented,
                value.DateReturned,
                value.Const,
                Car = value.TypeOfCar.Make + " " + value.TypeOfCar.Model
            }).ToList();
            gvRentalList.DataSource = records;
            gvRentalList.Columns["ID"].Visible = false;
        }
    }
}
