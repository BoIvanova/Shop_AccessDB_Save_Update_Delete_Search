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

namespace Shop_AccessDB_Save_Update_Delete_Search
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp1\Database_Shop_Project.accdb");


        public Form1()
        {
            InitializeComponent();
        }


        private void btnGoToClients_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
        }

        private void btnGoToSales_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
