using DocumentFormat.OpenXml.Bibliography;
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
    public partial class AddCarRentalRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        private bool isEditMode;
        private readonly ManageRentalRecord record;
        public AddCarRentalRecord()
        {
            InitializeComponent();
            lbTitle.Text = "Add New Rental Record";
            carRentalEntities = new CarRentalEntities();
            record = new ManageRentalRecord();
            isEditMode = false;
        }
        public AddCarRentalRecord(CarRental carRental)
        {
            InitializeComponent();
            lbTitle.Text = "Edit New Rental Record";
            carRentalEntities = new CarRentalEntities();
            record = new ManageRentalRecord();
            PopulateFields(carRental);
            isEditMode = true;
        }
        private void PopulateFields(CarRental rental)
        {
            tbCustomerName.Text = rental.CustomerName;
            dtRented.Value = Convert.ToDateTime(rental.DateRented);
            dtReturned.Value = Convert.ToDateTime(rental.DateReturned);
            tbCost.Text = Convert.ToString(rental.Const);
            cbTypeCar.Text = rental.TypeOfCar.Make + " " + rental.TypeOfCar.Model;
            
        }
        private void Button1_Click(object sender,
                                   EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                decimal cost = Convert.ToDecimal(tbCost.Text);

                var carType = cbTypeCar.Text;

                var isValid = true;
                var errorMesssage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                    errorMesssage += "Missing something customer or type car \n";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMesssage += "Illegal message \n";
                }
                if (isValid)
                {
                    if (isEditMode)
                    {

                    }
                    else
                    {
                        var rentalRecored = new CarRental();
                        rentalRecored.CustomerName = customerName;
                        rentalRecored.DateRented = dateOut;
                        rentalRecored.DateReturned = dateIn;
                        rentalRecored.Const = (decimal)cost;
                        rentalRecored.TypeOfCarId = (int)cbTypeCar.SelectedValue;

                        carRentalEntities.CarRentals.Add(rentalRecored);
                        carRentalEntities.SaveChanges();

                        MessageBox.Show("Insert successfully");
                    }

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //var cars = carRentalEntities.TypeOfCars.ToList();
            var cars = carRentalEntities.TypeOfCars.Select(value => new {
                ID = value.Id,
                Name = value.Model
            }).ToList();
            cbTypeCar.ValueMember = "Id";
            cbTypeCar.DisplayMember = "Name";
            cbTypeCar.DataSource = cars;
        }
    }
}
