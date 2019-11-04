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
    /// Interaction logic for CabinSearch.xaml
    /// </summary>
    public partial class CabinSearch : Page
    {
        Group2Entities1 datagrid = new Group2Entities1();

        public CabinSearch()
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from cabin in datagrid.Cabins
                        orderby cabin.Name
                        select new
                        {
                            Namn = cabin.Name,
                            Bäddar = cabin.NumOfBeds,
                            Rum = cabin.NumOfRooms,
                            Storlek = cabin.Size,
                            Wifi = cabin.WIFI,
                            Kök = cabin.Kitchen
                        };
            datagrid1.ItemsSource = query.ToList();

            
        }   

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
