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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //void f_changemessage(string s)
        //{
        //    textBox1.Text = s;       
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text != textBox4.Text)
            {
                MessageBox.Show("密码不一致");
            }
            else            
            {
                string userId = textBox3.Text.Trim();
                string passwordStr = textBox1.Text;
                string newpassword = textBox2.Text;
                string passwordAgain = textBox4.Text;
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
                                if(reader.Read())
                                {
                                    string passwordTemp = reader.GetString(1);
                                    if (passwordTemp == passwordStr)
                                    {
                                        if(UpdatePassword(GetUserId.getUserId, newpassword))
                                        {
                                            MessageBox.Show("密码修改成功");
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("密码修改失败");
                                        }
                                    }
                                    else
                                    {
                                        this.Text = "密码错误";
                                    }
                                }                             
                            }
                            else
                            {
                                this.Text = "用户名不存在";
                            }
                        }
                    }
                }

            }

          
        }
        private bool UpdatePassword(string Id, string newpassword2)
        {
            string sql = string.Format("update dbo.UserID set Passwrod='{0}' where UserIdPwd='{1}'", newpassword2, Id);
            string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            using(SqlConnection con=new SqlConnection(constr))
            {
                using(SqlCommand cmd=new SqlCommand(sql,con))
                {
                    con.Open();
                    int r=cmd.ExecuteNonQuery();
                    return r>0;
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.Text = GetUserId.getUserId;
            //Form1 Frm1 = new Form1();
            //Frm1.changmessage += new ClickDelegateHander(f_changemessage);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
