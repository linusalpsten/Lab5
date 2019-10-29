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
            sqlConn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            sqlConn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO People(Name, Phone, Email)values('" + nameBox.Text + "','" + phonenumberBox.Text + "','" + emailBox.Text + "')", sqlConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Kund uppdaterad!");
            sqlConn.Close();
        }
    }
}

//SqlCommand cmd = new SqlCommand("Select Name, Phone, Email from People where Id=@Id",sqlConn);
//cmd.Parameters.AddWithValue("@Id")
//SqlDataReader reader = cmd.ExecuteReader();
//while(reader.Read())
//{
//    nameBox.Text = reader.GetValue(0).ToString();
//    //phonenumberBox.Items.Add(reader["phonenumber"].ToString());
//    //emailBox.Items.Add(reader["name"].ToString());
//}