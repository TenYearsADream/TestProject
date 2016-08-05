using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlToWinFrm
{
    
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void getMessage1(string message)
        {
            textBox1.Text = message;
        }
        public void getMessage2(string message)
        {
            textBox2.Text = message;
        }
        public void getMessage3(string message)
        {
            textBox3.Text = message;
        }
        public void getMessage4(string message)
        {
            textBox4.Text = message;
        }
        
        private void Add_Click(object sender, EventArgs e)
        {             
  
            string nameText = this.textBox1.Text;          
            string dateText = this.textBox3.Text;
            string courseText = this.textBox4.Text;
            if (nameText == "" || this.textBox2.Text == "" || dateText == "" || courseText == "")
            {
                Form2 childFrm = new Form2();
                childFrm.changemessage1 += new ClickDelegateHander1(getMessage1);
                childFrm.changemessage2 += new ClickDelegateHander2(getMessage2);
                childFrm.changemessage3 += new ClickDelegateHander3(getMessage3);
                childFrm.changemessage4 += new ClickDelegateHander4(getMessage4);
                childFrm.Show();
            }
            else
            {
                int scoreText = Convert.ToInt32(this.textBox2.Text);
                #region 插入数据
                //创建连接字符串
                string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated Security=True";
                //创建连接对象
                using (SqlConnection con = new SqlConnection(constr))
                {

                    //编写sql语句
                    string sql = string.Format("insert into dbo.Class122 values('{0}',{1},'{2}','{3}')", nameText, scoreText, dateText, courseText);
                    //创建执行sql语句的命令对象sqlcommand
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //打开连接
                        con.Open();
                        //cmd.CommandText = sql;
                        //cmd.Connection = con;
                        //开始执行sql语句
                        //cmd.ExecuteNonQuery();//insert\delete\update int类型 表示执行查询语句后所影响的行数  特别注意：只有执行insertdelete update时才会返回影响行数  执行其他语句永远返回负一
                        //cmd.ExecuteScalar();//当执行返回单个结果时
                        //cmd.ExecuteReader();//当查询出多行多列时
                        int r = cmd.ExecuteNonQuery();
                        affectAdd.Text = Convert.ToString(r);
                    }
                }
            }
            #endregion
        }

        private void delete_Click(object sender, EventArgs e)
        {
            #region 删除数据
            if (this.textBox5.Text == "")
            {
                this.Text = "请输出数据";
            }
            else
            {
                int scoreText = Convert.ToInt32(this.textBox5.Text);

                //连接字符串
                string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated security=true";
                //连接对象
                using (SqlConnection con = new SqlConnection(constr))
                {
                    //sql语句
                    string sql = string.Format("delete from dbo.Class122 where 学号={0}", scoreText);
                    //创建命令对象
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //打开连接
                        con.Open();
                        //执行
                        int r = cmd.ExecuteNonQuery();
                        if (r > 0)
                        {
                            this.textBox8.Text = "Delete success";
                        }
                        affectDelete.Text = Convert.ToString(r);
                    }
                }
            }
            #endregion
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            //写连接字符串
            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            //创建连接对象
            using (SqlConnection con = new SqlConnection(constr))
            {
                string nameText = this.textBox6.Text;
                int scoreText = Convert.ToInt32(this.textBox11.Text);
                string dateText = this.textBox7.Text;
                string courseText = this.textBox12.Text;
                int numberText = Convert.ToInt32(this.textBox9.Text);
                //sql
                string sql = string.Format("update dbo.Class122 set 成绩={0},姓名='{1}',入学日期='{2}',主修课程='{3}' where 学号={4}", scoreText, nameText, dateText, courseText, numberText);
                //创建命令对象
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //打开连接
                    con.Open();
                    //执行
                    int r = cmd.ExecuteNonQuery();
                    affectUpdate.Text = Convert.ToString(r);
                }
            }
        }
        //private void ChangTime(object sender, EventArgs e)
        //{
        //    this.Text = DateTime.Now.ToString();
        //}
        private void button1_Click(object sender, EventArgs e)
        {
          
            Thread thread = new Thread(() => {
                if (this.InvokeRequired)
                {
                    while (true)
                    {                        
                        this.Invoke(new Action<string>(s => { this.Text = s; }), DateTime.Now.ToString());
                        //BeginInvoke(new EventHandler(ChangTime),null);
                        Thread.Sleep(1000);
                    }                                
                }
                else
                {
                    this.Text = DateTime.Now.ToString();
                }              
            });
            thread.IsBackground = true;
            thread.Start();
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    TextBox tb = (TextBox)c;
                    tb.Text = string.Empty;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number=Convert.ToInt32(this.textBox10.Text);
            //连接字符串
            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;Integrated security=true";
            //连接对象
            using (SqlConnection con = new SqlConnection(constr))
            {
                //sql语句
                string sql = string.Format("select * from dbo.Class122 where 学号={0}", number);
                //创建命令对象
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //打开连接
                    con.Open();
                    //执行
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
