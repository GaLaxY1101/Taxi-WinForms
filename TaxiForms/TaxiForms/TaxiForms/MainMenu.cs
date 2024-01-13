using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taxi;
using static TaxiForms.Program;

namespace TaxiForms
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            string file = @"D:\Education\Programming\Term3\Саша\Taxi\taxi_console\taxi_console\xml\TaxiCompany.xml";
            MyTaxiCompany = TaxiCompany.ReadFromFile(file);
            InitializeComponent();
        }

        private void taxiChoiceButton_Click(object sender, EventArgs e)
        {
            if (enterNameTextBox.Text == "" || enterPhoneNumberTextBox.Text == "" ||
                startHouseNumberTextBox.Text == "" || startStreetTextBox.Text == "" ||
                destinationHouseNumberTextBox.Text == "" || destinationStreetTextBox.Text == "")
            {
                MessageBox.Show("Ви не ввели всі дані, необхідні для створення заказу.");
            }
            else 
            {
                FormProvider.TaxiChoice.MyCustomer = new Customer(enterNameTextBox.Text, enterPhoneNumberTextBox.Text);

                int entrance = 0;
                if (startEntranseNumberTextBox.Text == "") FormProvider.TaxiChoice.StartAddress = new StartPoint(startStreetTextBox.Text, Int32.Parse(startHouseNumberTextBox.Text));
                else FormProvider.TaxiChoice.StartAddress = new StartPoint(startStreetTextBox.Text, Int32.Parse(startHouseNumberTextBox.Text), Int32.Parse(startEntranseNumberTextBox.Text));

                FormProvider.TaxiChoice.DestinationAddress = new Address(destinationStreetTextBox.Text, Int32.Parse(destinationHouseNumberTextBox.Text));

                FormProvider.MainMenu.Hide();
                FormProvider.TaxiChoice.Show();
            }
            
        }

        private void deliveryChoiceButton_Click(object sender, EventArgs e)
        {
            if (enterNameTextBox.Text == "" || enterPhoneNumberTextBox.Text == "" ||
                startHouseNumberTextBox.Text == "" || startStreetTextBox.Text == "" ||
                destinationHouseNumberTextBox.Text == "" || destinationStreetTextBox.Text == "")
            {
                MessageBox.Show("Ви не ввели всі дані, необхідні для створення заказу.");
            }
            else
            {
                FormProvider.DeliveryChoice.MyCustomer = new Customer(enterNameTextBox.Text, enterPhoneNumberTextBox.Text);

                int entrance = 0;
                if (startEntranseNumberTextBox.Text == "") FormProvider.DeliveryChoice.StartAddress = new StartPoint(startStreetTextBox.Text, Int32.Parse(startHouseNumberTextBox.Text));
                else FormProvider.DeliveryChoice.StartAddress = new StartPoint(startStreetTextBox.Text, Int32.Parse(startHouseNumberTextBox.Text), Int32.Parse(startEntranseNumberTextBox.Text));

                FormProvider.DeliveryChoice.DestinationAddress = new Address(destinationStreetTextBox.Text, Int32.Parse(destinationHouseNumberTextBox.Text));


                FormProvider.MainMenu.Hide();
                FormProvider.DeliveryChoice.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            MyTaxiCompany.CarsNotFoundEvent += (String) => MessageBox.Show(String);
            //SoundPlayer simpleSound = new SoundPlayer(@"D:\Education\Programming\Term3\Саша\Taxi\TaxiForms\TaxiForms\TaxiForms\wav\taxi.wav");
            //simpleSound.Play();
        }
    }
}
