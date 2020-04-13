using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CustomerRecords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String str = "";
        String selectedId = "";
        String deleteType = "";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath+ "\\DatabaseMain.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;
        private void getCustomer(String PNumberOrLName)
        {
            
            
            try
            {
                f1dataGridView2.DataSource = null;
                f1dataGridView2.Visible = false;
                f1dataGridView3.DataSource = null;
                f1dataGridView3.Visible = false;
                f1button7.Visible = false;
                f1button8.Visible = false;


                String pro = " ";
                String search = " ";
                if (PNumberOrLName.StartsWith("0") ^ PNumberOrLName.StartsWith("1") ^ PNumberOrLName.StartsWith("2")
                    ^ PNumberOrLName.StartsWith("3") ^ PNumberOrLName.StartsWith("4") ^ PNumberOrLName.StartsWith("5")
                    ^ PNumberOrLName.StartsWith("6") ^ PNumberOrLName.StartsWith("7") ^ PNumberOrLName.StartsWith("8")
                    ^ PNumberOrLName.StartsWith("9"))
                {
                    pro = "PsearchCustomerSP";
                    search = "PhoneNumber";
                } else
                {
                    pro = "LsearchCustomerSP";
                    search = "LastName";
                }

                if (PNumberOrLName.Equals(""))
                {
                    pro = "fetchAllCustomers";
                }

                SqlCommand cmd = new SqlCommand(pro, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@" + search, PNumberOrLName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0) {
                    //no results
                    MessageBox.Show("No Results");
                    return;

                }
           

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input " + ex);
                    f1dataGridView1.Rows.Clear();
                    f1dataGridView2.Rows.Clear();
                }

              
                f1dataGridView1.DataSource = ds.Tables[0];
               f1dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode.Fill);
                deleteType = "customer";
                this.f1dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
                this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteRow);

                //f1dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            } catch (Exception ex)
            {
                MessageBox.Show("Invalid Input " + ex);
            }
            ////////////////////////////////////////////
            try
            {
                f1dataGridView1.Visible = true;
                str = f1dataGridView1.CurrentRow.Cells[0].Value.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input " + ex);
            }
        }
        private void createNewCustomer(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            //this.Hide();
            obj.Show();
        }

        private void searchCustomer(object sender, EventArgs e)
        {
            getCustomer(f1textBox1.Text);
            

        }
        private void DataGridView_MouseDown(object sender, MouseEventArgs e)
        {


            try {
                DataGridView selected = (DataGridView)sender;
               
                if (e.Button == MouseButtons.Right)
                {
                    var hti = selected.HitTest(e.X, e.Y);
                    selected.ClearSelection();
                    selected.Rows[hti.RowIndex].Selected = true;
                    if(selected.RowCount-1 < hti.RowIndex)
                    {
                        selectedId = null;
                        return;
                    }
                 
                    selectedId = selected.Rows[hti.RowIndex].Cells[0].Value.ToString();

                    if (selected == f1dataGridView1)
                    {
                        deleteType = "customer";
                    }
                    if (selected == f1dataGridView2)
                    {
                        deleteType = "pet";
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
            }

        }


        private void DeleteRow(object sender, EventArgs e)
        {

            if(selectedId == null)
            {
                return;
            }
            String command = "";
            String paramater = "";
            try
            {

                if (deleteType.Equals("customer"))
                {
                    command = "removeCustomerById";
                    paramater = "@CustomerId";
                
                  
                }
                else if (deleteType.Equals("pet"))
                {
                    command = "removePetById";
                    paramater = "@PetId";
        
                
                }
                else if (deleteType.Equals("order"))
                {
  
                }
                else
                {
                    MessageBox.Show("Delete Type Error");
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            SqlCommand cmd = new SqlCommand(command, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue(paramater, selectedId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
       
                con.Open();
                cmd.ExecuteNonQuery();
          

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error" + ex.ToString());
            }
            finally
            {
                con.Close();

            }

            getCustomer("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form3 obj = new Form3(str);
            //this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1dataGridView1.Visible = false;
            f1dataGridView2.Visible = false;
            f1dataGridView3.Visible = false;
            f1button7.Visible = false;
            f1button8.Visible = false;
            f1textBox1.Text = "";
        }

        private void update()
        {
            if (f1dataGridView2.CurrentRow.Index == f1dataGridView2.Rows.Count)
            {
                return;
            }
            int petID = Convert.ToInt32(f1dataGridView2.CurrentRow.Cells[0].Value);
            SqlCommand cmd3 = new SqlCommand("searchOrder", con);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@PetID", petID);
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataSet ds = new DataSet();
            da.Fill(ds);
            try
            {
                con.Open();
                cmd3.ExecuteNonQuery();
                con.Close();
                f1button8.Visible = true;
                if (ds.Tables[0].Rows.Count == 0)
                {
                    //no results
                    MessageBox.Show("No results");
                    f1dataGridView3.DataSource = null;
                    return;

                }
                f1dataGridView3.DataSource = ds.Tables[0];
                f1dataGridView3.Visible = true;
                f1dataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode.Fill);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input " + ex);
            }
        }

        private void f1button8_Click(object sender, EventArgs e)
        {

            Form4 obj = new Form4(Convert.ToInt32(f1dataGridView2.CurrentRow.Cells[0].Value), f1dataGridView2.CurrentRow.Cells[3].Value.ToString());
            //this.Hide();
            obj.Show();
            update();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void f1dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            update();
     
        }

        private void f1dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (f1dataGridView1.CurrentRow.Index == f1dataGridView1.Rows.Count)
            {
                return;
            }
            f1dataGridView3.DataSource = null;
            f1dataGridView3.Visible = false;
            f1button8.Visible = false;
            int customerId = Convert.ToInt32(f1dataGridView1.CurrentRow.Cells[0].Value);
            SqlCommand cmd = new SqlCommand("pets", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                f1dataGridView2.DataSource = ds.Tables[0];
                f1dataGridView2.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode.Fill);
                deleteType = "pet";
                this.f1dataGridView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView_MouseDown);
                this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteRow);
                f1dataGridView2.Visible = true;
                f1button7.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input " + ex);
                f1dataGridView1.Rows.Clear();
                f1dataGridView2.Rows.Clear();
            }
            finally
            {
                con.Close();
            }
        
        }
    }
}
