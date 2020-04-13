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
using System.Collections.Generic;

namespace CustomerRecords
{
    public partial class Form4 : Form
    {
        public Form4(int petID, String size)
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            f4textBox2.Text = today.ToString("g");
            str = petID;
            str2 = size;
            //MessageBox.Show(str.ToString());
            calculatePrice();

        }

        int str = 0;
        String str2 = "";
        String str3 = "";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath+ "\\DatabaseMain.mdf;Integrated Security=True");
        private void f4_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("addOrderSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PetID", str);
            cmd.Parameters.AddWithValue("@Date", f4textBox2.Text);
            String items = "";
            for (int i = 0; i < f4checkedListBox1.Items.Count; i++)
            {
                if (f4checkedListBox1.GetItemChecked(i))
                {
                    items += (string)f4checkedListBox1.Items[i] + ", ";
                }
            }
            //MessageBox.Show(items);

            cmd.Parameters.AddWithValue("@Treatments", items);
            cmd.Parameters.AddWithValue("@TotalPrice", calculatePrice());

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
            
            this.Hide();
            
        }

        private int calculatePrice()
        {
            int total = 0;
            if (f4checkedListBox1.CheckedItems.Contains("Bath(30)"))
            {
                total += 30;
            }
            if (f4checkedListBox1.CheckedItems.Contains("DeSkunking(30)"))
            {
                total += 30;
            }
            if (f4checkedListBox1.CheckedItems.Contains("Nail Clippings(20)"))
            {
                total += 20;
            }
            if (f4checkedListBox1.CheckedItems.Contains("Untangling"))
            {
                total += 0;
            }
            if (f4checkedListBox1.CheckedItems.Contains("DeMatting"))
            {
                total += 0;
            }
            if (string.Equals(str2, "small", StringComparison.OrdinalIgnoreCase))
            {
                total += 48;
            } else if (string.Equals(str2, "medium", StringComparison.OrdinalIgnoreCase))
            {
                total += 55;
            } else if (string.Equals(str2, "large", StringComparison.OrdinalIgnoreCase))
            {
                total += 60;
            }
            f4textBox3.Text = "$ " + total + ".00";
            return total;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void f4checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculatePrice();
        }

    }
}
