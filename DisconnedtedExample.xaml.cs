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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace CodeFirstApproach
{
    /// <summary>
    /// Interaction logic for DisconnedtedExample.xaml
    /// </summary>
    public partial class DisconnedtedExample : Window
    {
        public DisconnedtedExample()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataTable dt;
        String stmt = "";
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            string con = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            
           
            if (btn.Name == "btninsert" || btn.Name == "btnupdate")
            {
                cmb = new SqlCommandBuilder(da);
                da.Update(dt);
               // da.Fill(dt);
                grd1.ItemsSource = dt.DefaultView;
            }
          
            else if (btn.Name == "btndelete")
            {
                stmt = "delete from Students  where Rno='" + txt1.Text + "'";
            }
            else
            {
                stmt = "select * from students";
            }
            SqlCommand cmd = new SqlCommand(stmt, conn);
            
            if (btn.Name != "btnshow")
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("DML Successfully");
                conn.Close();
            }
            else
            {
               da = new SqlDataAdapter(stmt, conn);
               dt = new DataTable();
                da.Fill(dt);
                grd1.ItemsSource = dt.DefaultView;
               

            }
           
        }

        private void grd_selection(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
