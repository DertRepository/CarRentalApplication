﻿using System;
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
    public partial class AddEditVehicle : Form
    {
        private bool isEditMode;
        private readonly CarRentalEntities _db;
        public AddEditVehicle()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            lbl_header_title.Text = "ADD VEHICLE";
            isEditMode = false;
        }
        public AddEditVehicle(TypeOfCar carToEdit)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            lbl_header_title.Text = "EDIT VEHICLE";
            isEditMode = true;
            PopulateFields(carToEdit);
        }
        private void PopulateFields(TypeOfCar car)
        {
            lblId.Text = car.Id.ToString();
            tbMake.Text = car.Make ;
            tbModel.Text = car.Model;
            tbVin.Text = car.VIN;
            tbLicense.Text = car.LicensePlatNumber;
            tbYear.Text = Convert.ToString(car.Year);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                var id = int.Parse(lblId.Text);
                var car = _db.TypeOfCars.FirstOrDefault(value => value.Id == id);
                car.Make = tbMake.Text;
                car.Model = tbModel.Text;
                car.VIN = tbVin.Text;
                car.LicensePlatNumber = tbLicense.Text;
                car.Year = int.Parse(tbYear.Text);

                _db.SaveChanges();

                MessageBox.Show("Successfully");
            }
            else
            {
                var car = new TypeOfCar()
                {
                    Make = tbMake.Text,
                    Model = tbModel.Text,
                    VIN = tbVin.Text,
                    LicensePlatNumber = tbLicense.Text,
                    Year = int.Parse(tbYear.Text)
                };
                _db.TypeOfCars.Add(car);
                _db.SaveChanges();
                MessageBox.Show("Successfully");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
