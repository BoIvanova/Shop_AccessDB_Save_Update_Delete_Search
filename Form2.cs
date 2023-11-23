using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp1\Database_Shop_Project.accdb");

        public Form2()
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

                cmd.CommandText = "select * from Clients";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dgvClients.DataSource = dt;


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }





        private void Form2_Load(object sender, EventArgs e)
        {

            dataviewer();

        }
    }
}
