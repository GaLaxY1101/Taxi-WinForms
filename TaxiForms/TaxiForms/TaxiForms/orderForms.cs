using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TaxiForms.Program;

namespace TaxiForms
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void goMainMenuButton_Click(object sender, EventArgs e)
        {
            FormProvider.OrderForm.Hide();
            FormProvider.MainMenu.Show();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            startStreetValueLabel.Text = myOrder.StartPoint.Street;
            startHouseNumberValueLabel.Text = myOrder.StartPoint.HouseNumber.ToString();
            startEntranceNumberValueLabel.Text = myOrder.StartPoint.EntranceNumber.ToString();
            destinationStreetValueLabel.Text = myOrder.DestinationPoint.Street;
            destinationHouseNumberValueLabel.Text = myOrder.DestinationPoint.HouseNumber.ToString();

            carModelValueLabel.Text = myOrder.Auto.Model;
            carColourValueLabel.Text = myOrder.Auto.Colour;
            carNumberValueLabel.Text = myOrder.Auto.CarNumber;
            priceValueLabel.Text = myOrder.Price.ToString();
        }
    }
}
