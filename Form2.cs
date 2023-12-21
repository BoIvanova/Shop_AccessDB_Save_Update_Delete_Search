using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_AccessDB_Save_Update_Delete_Search
{


    public partial class Form2 : Form
    {
        

        string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp1\Database_Shop_Project.accdb";
        OleDbConnection dbConnect = new OleDbConnection();

        

        void dataviewer()
        {

            try
            {

              string mySelect = "select * from Clients"; 
                dbConnect.ConnectionString = conString; 
                dbConnect.Open();
                OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, dbConnect);
                DataTable dt = new DataTable(); 
                adapt.Fill(dt);
                dgvClients.DataSource = dt;
                dbConnect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Close();
            }

        }

        public Form2()
        {
            InitializeComponent();
        }

       





        private void Form2_Load(object sender, EventArgs e)
        {
        

            dataviewer();

        }


        //clients shopped in last week
        private void btnClientsShopedlastWeek_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conString;
            string sqlQuery = " Select c.FirstName, c.LastName, s.OrderDate from Clients inner join Sales ON Clients.ClientID=Sales.CientID";
            //OleDbCommand cmd = dbConnect.CreateCommand();
            dbConnect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlQuery, dbConnect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvClients.DataSource = dt;
            dbConnect.Close();


        }



        //insert client
        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            try { 
            dbConnect.ConnectionString = conString;
            string sqlQuery = "Insert into Clients(FirstName,LastName,CardNumber,City,Address,Phone,Email)values(@FirstName,@LastName,@CardNumber,@City,@Address,@Phone,@Email)  ";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, dbConnect);
            cmd.Parameters.AddWithValue("@FirstName", textBoxFName.Text);
            cmd.Parameters.AddWithValue("@LastName", textBoxLName.Text);
            cmd.Parameters.AddWithValue("@CardNumber", textBoxCardNumber.Text);
            cmd.Parameters.AddWithValue("@City", textBoxCity.Text);
            cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
            cmd.Parameters.AddWithValue("@Email", textBoxMail.Text);
            
            dbConnect.Open();
            cmd.CommandText = sqlQuery;
            cmd.Connection = dbConnect;
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Record saved in DB", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbConnect.Close();

                dataviewer();
            }

            catch (Exception ex) 
            
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }


        //update table
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            try 
            {
                dbConnect.ConnectionString = conString;
                string sqlQuery = "Update Clients set FirstName= , LastName= , CardNumber= , City= , Address= , Phone= , Email= , where ClientID= ,";
                OleDbCommand cmd = new OleDbCommand(sqlQuery, dbConnect);
                cmd.Parameters.AddWithValue("@FirstName", textBoxFName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBoxLName.Text);
                cmd.Parameters.AddWithValue("@CardNumber", textBoxCardNumber.Text);
                cmd.Parameters.AddWithValue("@City", textBoxCity.Text);
                cmd.Parameters.AddWithValue("@Address", textBoxAddress.Text);
                cmd.Parameters.AddWithValue("@Phone", textBoxPhone.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxMail.Text);
                cmd.Parameters.AddWithValue("@ClientID", textBoxClientID.Text);

                dbConnect.Open();
                cmd.CommandText = sqlQuery;
                cmd.Connection = dbConnect;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record updated", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbConnect.Close();

                dataviewer();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
      
            
        }
        //taking the data from dgv, when clicking in cell
        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                textBoxClientID.Text = dgvClients.SelectedRows[0].Cells[0].Value.ToString();
                textBoxFName.Text = dgvClients.SelectedRows[0].Cells[1].Value.ToString();
                textBoxLName.Text = dgvClients.SelectedRows[0].Cells[2].Value.ToString();
                textBoxCardNumber.Text = dgvClients.SelectedRows[0].Cells[3].Value.ToString();
                textBoxCity.Text = dgvClients.SelectedRows[0].Cells[4].Value.ToString();
                textBoxAddress.Text = dgvClients.SelectedRows[0].Cells[5].Value.ToString();
                textBoxPhone.Text = dgvClients.SelectedRows[0].Cells[6].Value.ToString();
                textBoxMail.Text = dgvClients.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }




        //delete from table
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.ConnectionString = conString;
                string sqlQuery = "Delete * from Clients where ClientID=@ClientID ";
                OleDbCommand cmd = dbConnect.CreateCommand(); 
                cmd.Parameters.AddWithValue("@ClientID", textBoxClientID.Text);
                dbConnect.Open();
                cmd.CommandText = sqlQuery;
                cmd.Connection = dbConnect;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                dbConnect.Close();

                dataviewer();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //refresh the data grid view 
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataviewer();
        }



        private void btnClearDataForm2_Click(object sender, EventArgs e)
        {
            textBoxClientID.Text = " ";
            textBoxFName.Text = " ";
            textBoxLName.Text = " ";
            textBoxCardNumber.Text = " ";
            textBoxCity.Text = " ";
            textBoxAddress.Text = " ";
            textBoxPhone.Text = " ";
            textBoxMail.Text = " ";


        }
         //search for clients
        private void btnSearchClient_Click(object sender, EventArgs e)
        {
            try
            {
                dbConnect.ConnectionString = conString;
                OleDbCommand cmd = dbConnect.CreateCommand();
                string sqlQuery = "SELECT * FROM Clients WHERE ClientID "+
                    "LIKE @SearchText OR FirstName " +
                    "LIKE @SearchText OR LastName LIKE @SearchText OR "+
                    "CardNumber LIKE @SearchText  OR City LIKE @SearchText OR Address LIKE @SearchText OR "+
                    "Phone LIKE @SearchText OR Email LIKE @SearchText ";
               
                cmd.Parameters.AddWithValue("@SearchText", "%" + textBoxSearchClient.Text + "%");
                cmd.CommandText = sqlQuery;
                dbConnect.Open();

                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgvClients.DataSource = dt;
                dbConnect.Close();

            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }








        private void btnGoToProducts_Click(object sender, EventArgs e)
        {
           

        }
    }
}
