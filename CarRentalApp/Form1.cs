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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    MessageBox.Show($"Type of Car: {carType} Rented: {dateOut} Returned: {dateIn} Cost: {cost}");
                else
                    MessageBox.Show(errorMesssage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
