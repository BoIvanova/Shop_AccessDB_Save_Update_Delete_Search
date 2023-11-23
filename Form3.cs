using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Shop_AccessDB_Save_Update_Delete_Search
{
    public partial class Form3 : Form
    {


        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp1\Database_Shop_Project.accdb");
        public Form3()
        {
            InitializeComponent();
        }





        void dataviewer()
        {

            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from Sales";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataviewer();


            // Replace with your actual start and end dates
            DateTime startDate = dtpStart.Value;

            DateTime endDate = dtpEnd.Value;

            // Call the method to draw the pie chart



            dtpOrderDate.Value = DateTime.Now;

        }

        private void DrawPieChart(DateTime startDate, DateTime endDate)
        {

            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select  Sales.SalesID, Products.ProductName from Sales inner join Products on Sales.SKU = Products.SKU where Sales.OrderDate between '" + dtpStart.Value + "' and '" + dtpEnd.Value + " ' ";
                //cmd.Retri();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;

                Chart chart = new Chart();
                chart.Dock = DockStyle.Fill;

                // Add a series to the chart
                Series series = new Series("ProductName");
                series.ChartType = SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(row["ProductName"].ToString(), Convert.ToDouble(row["TotalProducts"]));

                }

                chart.Series.Add(series);

                Controls.Add(chart);


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }






        }


        private void buttonDrawChart_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            DrawPieChart(startDate, endDate);
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into Sales(ClientID,SKU,OrderDate,PaymentDate,Payed,Returned)values(' " + textBoxClientID.Text + " ',' " + textBoxProductNumber.Text + " ', '" + dtpOrderDate.Value + " ', '" + dtpPaymentdate.Value + " ', ' "+ (checkBoxPayed.CheckState == CheckState.Checked ? 1 : 0 ) + "',' " +( checkBoxReturned.CheckState == CheckState.Checked ? 1 : 0 )+ "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved in DB", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }



        //
        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            try



            {
                textBoxOrderID.Text = dgvSales.SelectedRows[0].Cells[0].Value.ToString();
                textBoxClientID.Text = dgvSales.SelectedRows[0].Cells[1].Value.ToString();
                textBoxProductNumber.Text = dgvSales.SelectedRows[0].Cells[2].Value.ToString();
                dtpOrderDate.Value = Convert.ToDateTime(dgvSales.SelectedRows[0].Cells[3].Value);
                dtpPaymentdate.Value = Convert.ToDateTime(dgvSales.SelectedRows[0].Cells[4].Value);
                checkBoxPayed.CheckState = Convert.ToBoolean(dgvSales.SelectedRows[0].Cells[5].Value) ? CheckState.Checked : CheckState.Unchecked;
                checkBoxReturned.CheckState = Convert.ToBoolean(dgvSales.SelectedRows[0].Cells[6].Value) ? CheckState.Checked : CheckState.Unchecked;







            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }



        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {



                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update Sales set ClientID= " + textBoxClientID.Text + " ,SKU=" + textBoxProductNumber.Text + ", OrderDate='" + dtpOrderDate.Value +
                                                            "', PaymentDate='" + dtpPaymentdate.Value + "',Payed = '" + (checkBoxPayed.Checked ? 1 : 0) +
                                                            " ' , Returned=' " + (checkBoxReturned.Checked ? 1 : 0) + " '  where SalesID = " + textBoxOrderID.Text + " ";
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

 


       

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete * from  Sales where SalesID= " + textBoxOrderID.Text + " ";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record deleted successfully", "Delete from Data base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }








        private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
        {
            
        }






        private void checkBoxPayed_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }




        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnpayed_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Sales where Payed = "+Convert.ToBoolean(checkBoxPayed.CheckState == CheckState.Checked) +" ";

                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }




        private void buttonReturned_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Sales where Returned <> " + Convert.ToBoolean(checkBoxReturned.CheckState == CheckState.Checked) + " ";

                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }





        }

        private void buttonPayed_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Sales where Payed <> " + Convert.ToBoolean(checkBoxPayed.CheckState == CheckState.Checked) + " ";

                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void buttonUnreturned_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Sales where Returned = " + Convert.ToBoolean(checkBoxPayed.CheckState == CheckState.Checked) + " ";

                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void buttonMostOrderd_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1 COUNT(DISTINCT Sales.SKU)   AS MostSoldProduct from  Sales ";

                conn.Close();

                // Call the dataviewer method after retrieving data
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvSales.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }





        }
    }





















}
