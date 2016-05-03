using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace KasperApp
{
    public partial class inventario : Form
    {
        public inventario()
        {
            InitializeComponent();
        }
        string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
       

        private void btnCatOk_Click(object sender, EventArgs e)
        {
            //0 tipo [all/name]
            //1 query by name
            string[] SPData = new string[2];
            MySqlConnection dbcon = new MySqlConnection(constring);
            
            string query = "";
            DataTable resultset = new DataTable();

            try
            {
                if (rdnCatAll.Checked == true)
                {
                    SPData[0] = "all";
                    SPData[1] = "";
                    query = "Call listItems('" + SPData[0] + "','" + SPData[1] + "')";
                    dbcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, dbcon);
                    da.Fill(resultset);
                    dgvResult.DataSource = resultset;
                    dbcon.Close();

                }
                else if(rdnItem.Checked==true)
                {
                    SPData[0] = "name";
                    SPData[1] = txtCatString.Text;
                    query = "Call listItems('" + SPData[0] + "','" + SPData[1] + "')";
                    dbcon.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, dbcon);
                    da.Fill(resultset);
                    dgvResult.DataSource = resultset;
                    dbcon.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        public void cargar1()
        {
            try
            {
                string[] SPData = new string[2];
                string query = "";
                DataTable resultsetItems = new DataTable();
                MySqlConnection dbcon = new MySqlConnection(constring);
                SPData[0] = "all";
                SPData[1] = "";
                query = "Call listItems('" + SPData[0] + "','" + SPData[1] + "')";
                dbcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbcon);
                da.Fill(resultsetItems);
                dgvResult.DataSource = resultsetItems;
                dbcon.Close();

                cmbInIdItem.DataSource = resultsetItems;
                cmbInIdItem.DisplayMember = "idItems";
                cmbInIdItem.ValueMember = "idItems";

                cmbInName.DataSource = resultsetItems;
                cmbInName.DisplayMember = "Name";
                cmbInName.ValueMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void cargar2()
        {
            try
            {
                string[] SPData = new string[2];
                string query = "";
                DataTable resultsetItems = new DataTable();
                MySqlConnection dbcon = new MySqlConnection(constring);
                SPData[0] = "all";
                SPData[1] = "";
                query = "Call listItems('" + SPData[0] + "','" + SPData[1] + "')";
                dbcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(query, dbcon);
                da.Fill(resultsetItems);
                dgvResult.DataSource = resultsetItems;
                dbcon.Close();

                cmbOutId.DataSource = resultsetItems;
                cmbOutId.DisplayMember = "idItems";
                cmbOutId.ValueMember = "idItems";

                cmbOutName.DataSource = resultsetItems;
                cmbOutName.DisplayMember = "Name";
                cmbOutName.ValueMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnAddItemOk_Click(object sender, EventArgs e)
        {
            string[] SPData = new string[5];
            string query = "";
            MySqlConnection conn = new MySqlConnection(constring);
            try
            {
                SPData[0] = txtNewId.Text;
                SPData[1] = txtNewName.Text;
                SPData[2] = txtNewDesc.Text;
                SPData[3] = txtNewQuan.Text;
                query = "call new_item("+Convert.ToInt32(SPData[0])+",'"+SPData[1]+"','"+SPData[2]+"',"+SPData[3]+");";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Item added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargar1();
                cargar2();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control tb in gpbNew.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = "";
                }
            }
        }

        private void btnCatCancel_Click(object sender, EventArgs e)
        {
            foreach (Control tb in gpbCat.Controls)
            {
                if (tb is TextBox)
                {
                    tb.Text = "";
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] SPData = new string[5];
            string query = "";
            MySqlConnection conn = new MySqlConnection(constring);
            try
            {
                SPData[0] = cmbInIdItem.Text;
                SPData[1] = txtInQuant.Text;
                query = "call item_in(" + Convert.ToInt32(SPData[0]) + "," + Convert.ToInt32(SPData[1]) + ");";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Quantity added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargar1();
                cargar2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            cargar1();
            cargar2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] SPData = new string[5];
            string query = "";
            MySqlConnection conn = new MySqlConnection(constring);
            try
            {
                SPData[0] = cmbOutId.Text;
                SPData[1] = txtOutQuan.Text;
                query = "call item_out(" + Convert.ToInt32(SPData[0]) + "," + Convert.ToInt32(SPData[1]) + ");";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Quantity removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar1();
                cargar2();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
