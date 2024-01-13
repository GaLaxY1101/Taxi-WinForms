using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaxiForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(FormProvider.MainMenu);
        }

        public class FormProvider
        {
            private static MainMenu _mainMenu;
            public static MainMenu MainMenu
            {
                get
                {
                    if (_mainMenu == null)
                    {
                        _mainMenu = new MainMenu();
                    }
                    return _mainMenu;
                }
            }

            private static DeliveryChoiceForm _deliveryChoice;

            public static DeliveryChoiceForm DeliveryChoice
            {
                get
                {
                    if (_deliveryChoice == null)
                    {
                        _deliveryChoice = new DeliveryChoiceForm();
                    }
                    return _deliveryChoice;
                }
            }

            private static TaxiChoice _taxiChoice;

            public static TaxiChoice TaxiChoice
            {
                get
                {
                    if (_taxiChoice == null)
                    {
                        _taxiChoice = new TaxiChoice();
                    }
                    return _taxiChoice;
                }
            }

            private static OrderForm _orderForm;

            public static OrderForm OrderForm
            {
                get
                {
                    if (_orderForm == null)
                    {
                        _orderForm = new OrderForm();
                    }
                    return _orderForm;
                }
            }

        }
    }
}