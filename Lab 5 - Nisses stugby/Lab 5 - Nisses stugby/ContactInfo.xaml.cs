using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace Lab_5___Nisses_stugby
{
    /// <summary>
    /// Interaction logic for ContactInfo.xaml
    /// </summary>
    public partial class ContactInfo : Page
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        //private void Hyperlink_Click(object sender, RoutedEventArgs e)
        //{
        //    SendTestMail(mailurl.Text);
        //}
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            SendTestMail(mailurl.Text);
        }




        public void SendTestMail(string EmailUrl)
        {
            try
            {

                Outlook.Application oApp = new Outlook.Application();
                Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
                oMailItem.To = EmailUrl;
                // body, bcc etc...
                oMailItem.Display(true);

            }
            catch (Exception e)
            {

                Console.WriteLine("{0} Exception caught: ", e);
            }
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
    }
}



//Outlook.Application oApp = new Outlook.Application();
//Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
//oMailItem.To = EmailUrl;
//                // body, bcc etc...
//                oMailItem.Display(true);