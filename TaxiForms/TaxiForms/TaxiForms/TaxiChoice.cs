using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi;
using static TaxiForms.Program;

namespace TaxiForms
{
    public partial class TaxiChoice : Form
    {
        public TaxiChoice()
        {
            InitializeComponent();
        }

        private void chooseCarClassCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int ix = 0; ix < chooseCarClassCheckedListBox.Items.Count; ++ix)
                {
                    if (e.Index != ix) chooseCarClassCheckedListBox.SetItemChecked(ix, false);
                }
            }
        }

        private void chooseAdditionalOptionsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {

            if (chooseCarClassCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Ви не обрали клас авто.");
            }
            else
            {
                Taxi.Auto.carClasses demandCarClass = new Taxi.Auto.carClasses();
                var checkedItems = chooseCarClassCheckedListBox.CheckedItems;
                switch (checkedItems[0].ToString())
                {
                    case "Економ":
                        demandCarClass = Taxi.Auto.carClasses.Econom;
                        break;

                    case "Комфорт":
                        demandCarClass = Taxi.Auto.carClasses.Comfort;
                        break;

                    case "Бізнес":
                        demandCarClass = Taxi.Auto.carClasses.Business;
                        break;

                    case "Мінібус":
                        demandCarClass = Taxi.Auto.carClasses.MiniBus;
                        break;
                }
                Taxi.TaxiOrder order;

                if (chooseAdditionalOptionsCheckedListBox.CheckedItems.Count == 0)
                {
                    order = new Taxi.TaxiOrder(this.StartAddress, this.DestinationAddress, demandCarClass, this.MyCustomer);
                }
                else if (chooseAdditionalOptionsCheckedListBox.CheckedItems.Count == 1 && chooseAdditionalOptionsCheckedListBox.CheckedItems[0].ToString() == "Діти") 
                {
                    order = new Taxi.TaxiOrder(this.StartAddress, this.DestinationAddress, demandCarClass, this.MyCustomer, needBabyChair: true);
                }
                else if (chooseAdditionalOptionsCheckedListBox.CheckedItems.Count == 1 && chooseAdditionalOptionsCheckedListBox.CheckedItems[0].ToString() == "Тварини")
                {
                    order = new Taxi.TaxiOrder(this.StartAddress, this.DestinationAddress, demandCarClass, this.MyCustomer, needAnimalCage: true);
                }
                else { order = new Taxi.TaxiOrder(this.StartAddress, this.DestinationAddress, demandCarClass, this.MyCustomer, needAnimalCage: true, needBabyChair: true); }


                FormProvider.MainMenu.MyTaxiCompany.AddTaxiOrder(order);
                if(order.Auto != null)
                {
                    this.Hide();
                    FormProvider.OrderForm.myOrder = order;
                    FormProvider.OrderForm.Show();
                }
            }
        }
    }
}
