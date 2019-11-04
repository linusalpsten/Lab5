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
        Labb5Entities datagrid = new Labb5Entities();

        public CabinSearch()
        {
            InitializeComponent();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool wifi = (bool)WifiCheckbox.IsChecked;
            bool kitchen = (bool)KitchenCheckbox.IsChecked;
            int beds = 0;
            int.TryParse(BedAmount.Text, out beds);
            int size = 0;
            int.TryParse(CabinSize.Text, out size);

            var query = from cabin in datagrid.Cabins
                        orderby cabin.Name
                        where cabin.NumOfBeds >= beds && cabin.Size >= size
                        select new
                        {
                            Namn = cabin.Name,
                            Bäddar = cabin.NumOfBeds,
                            Rum = cabin.NumOfRooms,
                            Storlek = cabin.Size,
                            Wifi = cabin.WIFI,
                            Kök = cabin.Kitchen
                        };

            if (wifi)
            {
                query = query.Where(c => c.Wifi == "Yes");
            }
            if (kitchen)
            {
                query = query.Where(c => c.Kök == "Yes");
            }
            datagrid1.ItemsSource = query.ToList();
        }
    }
}
