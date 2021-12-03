using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cs_asp_021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {      //Driver
            string driverresult = string.Format("Driver-{0}", drivernameTextbox.Text);

            driverNameLabel.Content = driverresult;

            //Social Security
            int ss = int.Parse(ssTextbox.Text);


            string SSresult = string.Format("Social Security Number- {0:000-00-0000}", ss);

            SSresultLabel.Content = SSresult;

            //phonenumber

            int phone = int.Parse(PhoneTextbox.Text);

            string phoneResult = string.Format("Phone Number- {0:000-000-0000}", phone);

            PhoneLabel.Content = phoneResult;

            //miles

            int SM = int.Parse(SMTextbox.Text);
            int EM = int.Parse(EMTextbox.Text);

            int Miles = EM - SM;

            string miles = string.Format("Total Miles: {0}", Miles);

            TotalMiles.Content = miles;

            //refrigerated and total pay due

            if (RefrigeratedCheckbox.IsChecked == true)
            {
                double num = .12;

                double numOne = Miles * num * 0.25;

                string total = string.Format("Total Pay Due- {0}", numOne);

                TotalPayDue.Content = total;

             }
            else
            {
                double Total = Miles * 0.25;

                string Tot = string.Format("Total Pay Due- {0}", Total);

                TotalPayDue.Content = Tot;

            }

            //Total days out

            var startdate = startDateCalendar.SelectedDate;

            var enddate = endDateCalendar.SelectedDate;

            var totaldays = startdate - enddate;

            string Totaldays = string.Format("Total Days Out- {0}", totaldays);

            Totaldaysout.Content = Totaldays;

            //Vaction Days

            var vac = totaldays 









        }
    }
}
