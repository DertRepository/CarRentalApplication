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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //SELECT * FROM TypeOfCars;
            var cars = _db.TypeOfCars
                .Select(value => new {
                    Model = value.Model,
                    Make = value.Make,
                    VIN = value.VIN,
                    License = value.LicensePlatNumber,
                    Year = value.Year,
                    value.Id
                }) // Select with aliase
                .ToList(); // -> Show it to list
            //var cars = _db.TypeOfCars.ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[5].Visible = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addEditVehicle = new AddEditVehicle();
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var id = (int) gvVehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypeOfCars.FirstOrDefault(value => value.Id == id);
            var addEditVehicle = new AddEditVehicle(car);
            addEditVehicle.MdiParent = this.MdiParent;
            addEditVehicle.Show();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
            var car = _db.TypeOfCars.FirstOrDefault(value => value.Id == id);
            _db.TypeOfCars.Remove(car);
            _db.SaveChanges();

            RefreshGv();
        }
        public void RefreshGv()
        {
            var cars = _db.TypeOfCars.Select(value => new
            {
                Model = value.Model,
                Make = value.Make,
                VIN = value.VIN,
                License = value.LicensePlatNumber,
                Year = value.Year,
                value.Id
            }).ToList();
            gvVehicleList.DataSource = cars;
        }
        private void btnRefreshCar_Click(object sender, EventArgs e)
        {
            RefreshGv();
        }
    }
}
