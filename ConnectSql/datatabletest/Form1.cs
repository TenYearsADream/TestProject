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

namespace datatabletest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "data source=SHZB-WANGXF2-DP\\MSSQL;initial catalog=MyFirstDatabase;integrated security=true";
            using (SqlConnection con = new SqlConnection(str))
            {
                DataTable myDataTable = new DataTable();
                DataSet myDataSet = new DataSet();
                string sql = "select * from 医生_专科病历片语维护";
                //using (SqlCommand cmd = new SqlCommand(sql, con))
                //{
                    //con.Open();
                    //using (SqlDataReader reader = cmd.ExecuteReader())
                    //{
                    //    if (reader.HasRows)
                    //    {
                    //        myDataTable.Load(reader);
                    //    }
                    //    dataGridView1.DataSource = myDataTable.DefaultView;
                     
                    //}

                    using(SqlDataAdapter adapter=new SqlDataAdapter(sql,con))
                    {
                        adapter.Fill(myDataTable);
                        dataGridView1.DataSource = myDataTable.DefaultView;
                    }
                    
                //}
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = this.dataGridView1.Rows[e.RowIndex];
        }

    }
}
