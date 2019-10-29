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
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = @"Data Source=iths.database.windows.net;Initial Catalog=Group2;Persist Security Info=True;User ID=Group2sa;Password= Group2Password!";
            sqlConn.Open();
            string query = "Select Max(Trans_No) from Auto_Number";
            SqlCommand cmd = new SqlCommand("INSERT INTO People( Name, Phone, Email)values('" + nameBox.Text + "','" + phonenumberBox.Text + "','" + emailBox.Text + "')", sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Kund uppdaterad!");
            
            sqlConn.Close();
        }
    }
}