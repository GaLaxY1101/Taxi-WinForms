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
using Taxi;

namespace TaxiForms
{
    public partial class DeliveryChoiceForm : Form
    {
        public DeliveryChoiceForm()
        {
            InitializeComponent();
        }

        private void deliveryByCarLabel_Click(object sender, EventArgs e)
        {
            DeliveryOrder order = new DeliveryOrder(FormProvider.DeliveryChoice.StartAddress, FormProvider.DeliveryChoice.DestinationAddress, DeliveryOrder.vehicleTypes.car, FormProvider.DeliveryChoice.MyCustomer);
            FormProvider.MainMenu.MyTaxiCompany.AddDeliveryOrder(order);

            if (order.Auto != null)
            {
                FormProvider.OrderForm.myOrder = order;
                FormProvider.DeliveryChoice.Hide();
                FormProvider.OrderForm.Show();
            }
        }

        private void deliveryBuLorryLabel_Click(object sender, EventArgs e)
        {
            DeliveryOrder order = new DeliveryOrder(FormProvider.DeliveryChoice.StartAddress, FormProvider.DeliveryChoice.DestinationAddress, DeliveryOrder.vehicleTypes.lorry, FormProvider.DeliveryChoice.MyCustomer);
            FormProvider.MainMenu.MyTaxiCompany.AddDeliveryOrder(order);

            if (order.Auto != null)
            {
                FormProvider.OrderForm.myOrder = order;
                FormProvider.DeliveryChoice.Hide();
                FormProvider.OrderForm.Show();
            }
        }
    }
}
