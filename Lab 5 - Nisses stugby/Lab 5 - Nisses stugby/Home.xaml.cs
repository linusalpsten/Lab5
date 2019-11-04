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

namespace Lab_5___Nisses_stugby
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnHome_click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            this.NavigationService.Navigate(home);
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            this.NavigationService.Navigate(registration);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            CabinSearch cabinSearch = new CabinSearch();
            this.NavigationService.Navigate(cabinSearch);
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            Administration administration = new Administration();
            this.NavigationService.Navigate(administration);
        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            ContactInfo contactinfo = new ContactInfo();
            this.NavigationService.Navigate(contactinfo);
        }

        private void Weather_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
