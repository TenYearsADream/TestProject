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

namespace UserLogin
{
    //public delegate void ClickDelegateHander(string message); //声明一个委托
    public partial class Form1 : Form
    {
        //public event ClickDelegateHander changmessage;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 使用带参数的SQL语句
            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select count(*) from dbo.UserID where UserIdPwd=@loginId and Passwrod=@password";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //SqlParameter paramLoginId = new SqlParameter("@loginId", SqlDbType.NVarChar, 50) {Value=textBox1.Text.Trim()};
                    //SqlParameter paramPassword = new SqlParameter("@password", SqlDbType.NVarChar, 50) {Value=textBox2.Text};
                    //cmd.Parameters.Add(paramLoginId);
                    //cmd.Parameters.Add(paramPassword);
                    //con.Open();
                    //-------------------------------------------------------
                    //SqlParameter[] pms = new SqlParameter[] {
                    //    new SqlParameter("@loginId", SqlDbType.NVarChar, 50) {Value=textBox1.Text.Trim()},
                    //    new SqlParameter("@password", SqlDbType.NVarChar, 50) {Value=textBox2.Text}
                    //};
                    //cmd.Parameters.AddRange(pms);
                    //-------------------------------------------------------
                    cmd.Parameters.AddWithValue("@loginId", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    int r = (int)cmd.ExecuteScalar();
                    if (r > 0)
                    {
                        this.Text = "登陆成功";
                    }
                    else
                    {
                        this.Text = "登陆失败";
                    }
                }
            }

            #endregion
            #region 使用拼接SQL语句

            //    string userId = textBox1.Text.Trim();
            //    string passwordStr = textBox2.Text;

            //    string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            //    using (SqlConnection con = new SqlConnection(constr))
            //    {
            //        string sql = string.Format("select count(*) from dbo.UserID where UserIdPwd='{0}' and Passwrod='{1}'", userId, passwordStr);
            //        using (SqlCommand cmd = new SqlCommand(sql, con))
            //        {

            //            //' or 1=1 --
            //            con.Open();
            //            int obj = (int)cmd.ExecuteScalar();//聚合函数查询数据不可能为空查不到数据就是为0
            //            if (obj > 0)
            //            {
            //                this.BackColor = Color.Green;
            //            }
            //            else
            //            {
            //                this.BackColor = Color.Red;
            //            }
            //        }
            //    }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //登陆用户名是否存在

            string userId = textBox1.Text.Trim();
            string passwordStr = textBox2.Text;

            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("select * from dbo.UserID where UserIdPwd='{0}'", userId);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //存在
                            if (reader.Read())
                            {
                                button4.Enabled = true;
                                string passwordTemp = reader.GetString(1);
                                if (passwordTemp == passwordStr)
                                {
                                    this.Text = "登陆成功";
                                    GetUserId.getUserId = reader.GetString(0);
                                }
                                else
                                {
                                    this.Text = "密码错误";
                                }
                            }
                        }
                        else
                        {
                            //不存在
                            this.Text = "用户不存在！";
                            button4.Enabled = false;
                        }
                    }
                }
            }
            //采集数据
            //先根据用户名去数据库中查找，是否用对应的用户
            //如果有对应的用户在比较密码是否正确
            //如果没有该用户直接提示用户名不存在
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form2 Frm2 = new Form2();
            Frm2.Show();

        }
    }
}
