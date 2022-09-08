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
    public partial class AddRecord : Form
    {
        private readonly CarRentalEntities carRentalEntities;
        public AddRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities();
        }

        private void Button1_Click(object sender,
                                   EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                var dateOut = dtRented.Value;
                var dateIn = dtReturned.Value;
                double cost = Convert.ToDouble(tbCost.Text);

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
                    var rentalRecored = new CarRental();
                    rentalRecored.CustomerName = customerName;
                    rentalRecored.DateRented = dateOut;
                    rentalRecored.DateReturned = dateIn;
                    rentalRecored.Const = (decimal) cost;
                    rentalRecored.TypeOfCarId = (int) cbTypeCar.SelectedValue;

                    carRentalEntities.CarRentals.Add(rentalRecored);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show("Insert successfully");
                }
                else
                    MessageBox.Show(errorMesssage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = carRentalEntities.TypeOfCars.ToList();
            cbTypeCar.ValueMember = "Id";
            cbTypeCar.DisplayMember = "Name";
            cbTypeCar.DataSource = cars;
        }
    }
}
