﻿using System;
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
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;

namespace Lab_5___Nisses_stugby
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        Labb5Entities dataEntities = new Labb5Entities();

        public Registration()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string sqlCommand = $"INSERT INTO People( Name, Phone, Email)values('{nameBox.Text}','{phonenumberBox.Text}','{emailBox.Text}')";
            dataEntities.Database.ExecuteSqlCommand(sqlCommand);
            dataEntities.SaveChanges();
            MessageBox.Show("Kund uppdaterad!");
        }
    }
}