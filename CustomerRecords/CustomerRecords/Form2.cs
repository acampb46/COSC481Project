using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerRecords
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            f2textBox5.Text = today.ToString("g");
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath+ "\\DatabaseMain.mdf;Integrated Security=True");
        int id = 0;
        private void getCustomer(String pnumber, String fname, String lname , String address)
        {
            SqlCommand cmd = new SqlCommand("addCustomerSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", fname);
            cmd.Parameters.AddWithValue("@LastName", lname);
            cmd.Parameters.AddWithValue("@PhoneNumber", pnumber);
            cmd.Parameters.AddWithValue("@Address", address);
            DateTime today = DateTime.Today;
            cmd.Parameters.AddWithValue("@AccountDOB", today);
            con.Open();

            try
            {
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid Input " + ex);
            }
            con.Close();

            SqlCommand cmd2 = new SqlCommand("getCustomerID", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@PhoneNumber", pnumber);

            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable ds = new DataTable();
                da.Fill(ds);
                id = Int32.Parse((string.Join(Environment.NewLine, ds.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)))));
                MessageBox.Show("Customer created succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input ");
            
            }
            con.Close();
        }
        private void f2button1_Click(object sender, EventArgs e)
        {
            getCustomer(f2textBox1.Text, f2textBox2.Text, f2textBox3.Text, f2textBox4.Text);
            Form3 obj = new Form3(id.ToString());
            this.Hide();
            obj.Show();
        }
    }
}
