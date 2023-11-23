using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Net.NetworkInformation;




namespace Shop_AccessDB_Save_Update_Delete_Search
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp1\Database_Shop_Project.accdb");

        int cheker;

        Bitmap bitmap;




        public Form1()
        {
            InitializeComponent();
        }




        //shows the DB after insert,update or delete a record 
        void  dataviewer()
        {

            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from Products";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvProducts.DataSource = dt;
                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }




        //here loads the dgv into the Form
        private void Form1_Load(object sender, EventArgs e)
        {
            dataviewer();
        }



        //allows clicking the Dgv only in Cell [0]
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                textBoxSKU.Text = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                textBoxProductName.Text = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                textBoxModell.Text = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
                textBoxDescription.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
                textBoxPrice.Text = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
                textBoxExpDate.Text = dgvProducts.SelectedRows[0].Cells[5].Value.ToString();
                textBoxPieces.Text = dgvProducts.SelectedRows[0].Cells[6].Value.ToString();


            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }


        //insert new product into DB
        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            try 
            {
            
            
            
            conn.Open();

            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Products(ProductName,Modell,Description,Price,ExpDate,Pieces)values('"+textBoxProductName.Text+"','" + textBoxModell.Text + " ', '" + textBoxDescription.Text + " ', '" + textBoxPrice.Text + " ', '" + textBoxExpDate.Text + " ', '" + textBoxPieces.Text + " ' )";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record saved in DB", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
                dataviewer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }



        //update record in DB
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {


            

            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update Products set ProductName= '"+textBoxProductName.Text+"' ,Modell=' " + textBoxModell.Text + "', Description='"+textBoxDescription.Text+
                                                            "', Price='"+textBoxPrice.Text+ "',ExpDate ='"+textBoxExpDate.Text+
                                                            "',Pieces='"+textBoxPieces.Text+"' where SKU = " + textBoxSKU.Text+ " ";
                cmd.ExecuteNonQuery();

                 conn.Close();

                MessageBox.Show("Record updatet successfully", "Update Data base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

      
        //delete record from DB
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete * from  Products where SKU=" + textBoxSKU.Text + " ";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record deleted successfully", "Delete from Data base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();

                textBoxSKU.Text = "";
                textBoxModell.Text = "";
                textBoxDescription.Text = "";
                textBoxPrice.Text = "";
                textBoxExpDate.Text = "";
                textBoxPieces.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }


        }


        //refresh the DataGridView
        private void btnView_Click(object sender, EventArgs e)
        {
            dataviewer();
        }


        //search for Product by criteria
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            cheker = 0;


            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from Products where SKU = '"+ textBoxSearchProduct.Text+"' or ProductName = '"+textBoxSearchProduct.Text+"' or Modell = '"+ textBoxSearchProduct.Text+ 
                    "' or Description = '"+ textBoxSearchProduct.Text+"'";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                cheker = Convert.ToInt32(dt.Rows.Count.ToString());
                dgvProducts.DataSource = dt;


                conn.Close();

                if (cheker == 0 )
                {

                    MessageBox.Show( "Record not found", "Error",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxSearchProduct.Text = " ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }


        //print
        private void btnPrintProduct_Click(object sender, EventArgs e)
        {

        }

        

        //clear the data in the textboxes
        private void btnClearData_Click(object sender, EventArgs e)
        {
            dataviewer();

            textBoxSKU.Text = "";
            textBoxProductName.Text = "";
            textBoxModell.Text = "";
            textBoxDescription.Text = "";
            textBoxPrice.Text = "";
            textBoxExpDate.Text = "";
            textBoxPieces.Text = "";
            textBoxSearchProduct.Text = "";
        }



        //products expired
        private void btnShowExpired_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Products WHERE ExpDate < Date() ";

                OleDbDataReader reader = cmd.ExecuteReader();

                // Check if the reader has rows before trying to read
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Access the data using the reader and display or process it as needed
                        string sku = reader["SKU"].ToString();
                        string productname = reader["ProductName"].ToString();
                        string modell = reader["Modell"].ToString();
                        string description = reader["Description"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        DateTime expDate = Convert.ToDateTime(reader["ExpDate"]);
                        int pieces = Convert.ToInt32(reader["Pieces"]);

                        // Display or process the data as needed
                        // You might want to use this data to update your UI or log it, for example
                    }
                    conn.Close();



                }
                else
                {
                    MessageBox.Show("No products found .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvProducts.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }


        //products expire whitin 24 hours
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Products WHERE ExpDate BETWEEN Date() AND DateAdd('h', 24, Date())";

                OleDbDataReader reader = cmd.ExecuteReader();

                // Check if the reader has rows before trying to read
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Access the data using the reader and display or process it as needed
                        string sku = reader["SKU"].ToString();
                        string productname = reader["ProductName"].ToString();
                        string modell = reader["Modell"].ToString();
                        string description = reader["Description"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        DateTime expDate = Convert.ToDateTime(reader["ExpDate"]);
                        int pieces = Convert.ToInt32(reader["Pieces"]);

                        // Display or process the data as needed
                        // You might want to use this data to update your UI or log it, for example
                    }
                    conn.Close();



                }
                else
                {
                    MessageBox.Show("No products found with expiration date in the next 24 hours.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvProducts.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }


        }


        //products expire in more than 3 months 
        private void btnExpDateMoreThan3M_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Products WHERE ExpDate > DateAdd('m', 3, Date())";

                OleDbDataReader reader = cmd.ExecuteReader();

                // Check if the reader has rows before trying to read
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Access the data using the reader and display or process it as needed
                        string sku = reader["SKU"].ToString();
                        string productname = reader["ProductName"].ToString();
                        string modell = reader["Modell"].ToString();
                        string description = reader["Description"].ToString();
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        DateTime expDate = Convert.ToDateTime(reader["ExpDate"]);
                        int pieces = Convert.ToInt32(reader["Pieces"]);

                        // Display or process the data as needed
                        // You might want to use this data to update your UI or log it, for example
                    }
                    conn.Close();



                }
                else
                {
                    MessageBox.Show("No products found .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvProducts.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }



        }


        //exit the Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Exit Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }


        }



        //open Form Clients
        private void btnGoToClients_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
        // Open Form Sales
        private void btnGoToSales_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }












        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {




        }


        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelExpDate_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSKU_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
