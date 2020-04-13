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
    public partial class Form3 : Form
    {
        public Form3(String customerID)
        {
            InitializeComponent();
            str = customerID;
        }
        String str = "";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath+ "\\DatabaseMain.mdf;Integrated Security=True");
        private void f3button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("addPetSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DogorCat", f3listBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Breed", listBox1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Color", f3textBox1.Text);
            cmd.Parameters.AddWithValue("@HairType", f3textBox7.Text);
            cmd.Parameters.AddWithValue("@Markings", f3textBox5.Text);
            cmd.Parameters.AddWithValue("@Allergies", f3textBox6.Text);
            cmd.Parameters.AddWithValue("@CustomerID", str);
            cmd.Parameters.AddWithValue("@Notes", f3textBox8.Text);
            cmd.Parameters.AddWithValue("@Name", f3textBox3.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("addpetsSP");
            }
            con.Close();

            SqlCommand cmd2 = new SqlCommand("pets2", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@CustomerID", str);
            cmd2.Parameters.AddWithValue("@Name", f3textBox3.Text);
            int id = 0;
            con.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable ds = new DataTable();
                da.Fill(ds);
                id = Int32.Parse((string.Join(Environment.NewLine, ds.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)))));
            }
            catch (Exception ex)
            {
                MessageBox.Show("pets2");

            }
            con.Close();
            Form4 obj1 = new Form4(id, listBox1.SelectedItem.ToString());
            this.Hide();
            obj1.Show();
        }
    }
}
