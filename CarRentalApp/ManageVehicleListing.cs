using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            try
            {
                var id = (int)gvVehicleList.SelectedRows[0].Cells["Id"].Value;
                var car = _db.TypeOfCars.FirstOrDefault(value => value.Id == id);
                _db.TypeOfCars.Remove(car);
                _db.SaveChanges();

                MessageBox.Show("Successsfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (gvVehicleList.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < gvVehicleList.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = gvVehicleList.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < gvVehicleList.Rows.Count; i++)
                {
                    for (int j = 0; j < gvVehicleList.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = gvVehicleList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
