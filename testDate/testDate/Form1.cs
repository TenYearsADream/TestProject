using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace testDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string conString;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = SQLselect();
            //"select UserUD=@userida,Name=@namea,Discribe=@discribea,SubmitTime=@submittimea from dbo.[User]";
            //SqlParameter[] pms = new SqlParameter[]
            //{
            //    new SqlParameter("@userida",SqlDbType.Int){Value=textBox1.Text.Trim()},
            //    new SqlParameter("@namea",SqlDbType.NVarChar,50){Value=textBox2.Text.Trim()}, 
            //    new SqlParameter("@discribea",SqlDbType.NVarChar,50){Value=textBox4.Text.Trim()},
            //    new SqlParameter("@submittimea",SqlDbType.DateTime){Value=textBox5.Text.Trim()}
            //};
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataSet(sql);
            DataTable dt = new DataTable();
            dt=ds.Tables[0];
            this.dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLinsert();
            //string sql = SQL();
            //DataSet ds = new DataSet();
            //ds = SqlHelper.ExecuteDataSet(sql);
            //DataTable dt = new DataTable();
            //dt = ds.Tables[0];

            //DataRow dr = dt.NewRow();
            //dr["Name"] = this.textBox2.Text.Trim();
            //dr["Password"] = this.textBox3.Text.Trim();
            //dr["Discribe"] = this.textBox4.Text.Trim();
            //dr["SubmitTime"] = DateTime.Now.ToString().Trim();
            //dt.Rows.Add(dr);
            //this.dataGridView1.DataSource = dt;
        }
        public string SQLselect()
        {
            string dafile = AppDomain.CurrentDomain.BaseDirectory + @"\DA.XML";
            if (!File.Exists(dafile))
            {
                throw new Exception(dafile + "文件丢失");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(dafile);
            XmlNodeList nodeList = doc.GetElementsByTagName("connectionStrings");
            XmlNode node = null;
            foreach (XmlNode item in nodeList)
            {
                if (item.Attributes["name"].Value == "MySql")
                {
                    node = item;
                    break;
                }
            }
            string conStr = node.Attributes["conString"].Value;
            conString = conStr;

            string sql = "select * from dbo.[User]";
            return sql;
        }
        public void SQLinsert()
        {
            string dafile = AppDomain.CurrentDomain.BaseDirectory + @"\DA.XML";
            if (!File.Exists(dafile))
            {
                throw new Exception(dafile + "文件丢失");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(dafile);
            XmlNodeList nodeList = doc.GetElementsByTagName("connectionStrings");
            XmlNode node = null;
            foreach (XmlNode item in nodeList)
            {
                if (item.Attributes["name"].Value == "MySql")
                {
                    node = item;
                    break;
                }
            }
            string conStr = node.Attributes["conString"].Value;
            conString = conStr;

            string sql = "INSERT INTO DBO.[User] (Name, Password, Discribe, SubmitTime) values(@namea,@passworda,@discribea,@submitTimea)";
            SqlParameter[] pms = new SqlParameter[]
            {             
                new SqlParameter("@namea",SqlDbType.NVarChar,50){Value=textBox2.Text.Trim()}, 
                new SqlParameter("@passworda",SqlDbType.NVarChar,50){Value=textBox3.Text.Trim()},
                new SqlParameter("@discribea",SqlDbType.NVarChar,50){Value=textBox4.Text.Trim()},
                new SqlParameter("@submitTimea",SqlDbType.DateTime){Value=DateTime.Now}
            };
            int r = SqlHelper.ExecuteNonQuery(sql, pms);
            if(r>0)
            {                             
                foreach(Control item in Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text =null;
                    }
                }
                textBox2.Focus();
                string s = SQLselect();
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataSet(s);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faile");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dafile = AppDomain.CurrentDomain.BaseDirectory + @"\DA.XML";
            if (!File.Exists(dafile))
            {
                throw new Exception(dafile + "文件丢失");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(dafile);
            XmlNodeList nodeList = doc.GetElementsByTagName("connectionStrings");
            XmlNode node = null;
            foreach (XmlNode item in nodeList)
            {
                if (item.Attributes["name"].Value == "MySql")
                {
                    node = item;
                    break;
                }
            }
            string conStr = node.Attributes["conString"].Value;
            conString = conStr;

            string sql = "Delete from dbo.[User] where UserID=@userida";
            SqlParameter[] pms = new SqlParameter[]
            {             
                new SqlParameter("@userida",SqlDbType.Int){Value=textBox6.Text.Trim()}               
            };

            int r = SqlHelper.ExecuteNonQuery(sql, pms);
            if(r>0)
            {
                textBox6.Clear();
                textBox6.Focus();
                string s = SQLselect();
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataSet(s);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Faile");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dafile = AppDomain.CurrentDomain.BaseDirectory + @"\DA.XML";
            if (!File.Exists(dafile))
            {
                throw new Exception(dafile + "文件丢失");
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(dafile);
            XmlNodeList nodeList = doc.GetElementsByTagName("connectionStrings");
            XmlNode node = null;
            foreach (XmlNode item in nodeList)
            {
                if (item.Attributes["name"].Value == "MySql")
                {
                    node = item;
                    break;
                }
            }
            string conStr = node.Attributes["conString"].Value;
            conString = conStr;

            //UserID, Name, Password, Discribe, SubmitTime
            string sql = "update dbo.[User] set Name=@namea,Password=@passworda,Discribe=@discribea,SubmitTime=GETDATE() where UserID=@userida";
            SqlParameter[] pms = new SqlParameter[]
            {             
                new SqlParameter("@userida",SqlDbType.Int){Value=textBox8.Text.Trim()},
                new SqlParameter("@namea",SqlDbType.NVarChar,50){Value=textBox1.Text.Trim()},
                new SqlParameter("@passworda",SqlDbType.NVarChar,50){Value=textBox5.Text.Trim()},
                new SqlParameter("@discribea",SqlDbType.NVarChar,50){Value=textBox7.Text.Trim()}
            };
            int r = SqlHelper.ExecuteNonQuery(sql, pms);
            if (r > 0)
            {
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text=null;
                    }
                }
                textBox8.Focus();
                string s = SQLselect();
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataSet(s);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
               
            }
            else
            {
                MessageBox.Show("不存在需要更新的UesrID");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow currentRow = this.dataGridView1.Rows[e.RowIndex];


                string s = currentRow.AccessibilityObject.Value;

                string[] sArray = s.Split(';');
                textBox10.Text = sArray[0];
                textBox9.Text = sArray[1];
                textBox11.Text = sArray[2];
                textBox12.Text = sArray[3];
                textBox13.Text = sArray[4];
         
            }
            catch (Exception ex)
            {

            
            }
           

          
            //DataGridViewRow currentRow = this.dataGridView1.Rows[e.RowIndex];

            //UserAttr userAttr = currentRow.DataBoundItem as UserAttr;

                                                                                                        
                         
            //    textBox10.Text=userAttr.UserID.ToString();
            //    textBox9.Text = userAttr.Name.ToString();
            //    textBox11.Text = userAttr.Password.ToString();
            //    textBox12.Text = userAttr.Discribe.ToString();
            //    textBox13.Text = userAttr.SubmitTime.ToLongDateString();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            //dataGridView1.BackgroundColor = Color.Red;

            //dataGridView1.BeginEdit(true);

          
            string sql = SQLselect();
            //"select UserUD=@userida,Name=@namea,Discribe=@discribea,SubmitTime=@submittimea from dbo.[User]";
            //SqlParameter[] pms = new SqlParameter[]
            //{
            //    new SqlParameter("@userida",SqlDbType.Int){Value=textBox1.Text.Trim()},
            //    new SqlParameter("@namea",SqlDbType.NVarChar,50){Value=textBox2.Text.Trim()}, 
            //    new SqlParameter("@discribea",SqlDbType.NVarChar,50){Value=textBox4.Text.Trim()},
            //    new SqlParameter("@submittimea",SqlDbType.DateTime){Value=textBox5.Text.Trim()}
            //};
            DataSet ds = new DataSet();
            ds = SqlHelper.ExecuteDataSet(sql);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
