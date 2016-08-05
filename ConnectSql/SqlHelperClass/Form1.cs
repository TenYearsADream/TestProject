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

namespace SqlHelperClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql="select count(*) from dbo.UserID where UserIdPwd=@loginId and Passwrod=@password ";
            SqlParameter[] pms=new SqlParameter[]{
                new SqlParameter("@loginId",SqlDbType.NVarChar,50){Value=textBox1.Text.Trim()},
                new SqlParameter("@password",SqlDbType.NVarChar,50){Value=textBox2.Text.Trim()}
            };
            int r = (int)SqlHelper.ExecuteScalar(sql, pms);
            if(r>0)
            {
                MessageBox.Show("登陆成功");
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<userID> list = new List<userID>();
            string constr = "select * from dbo.Class122";
            using(SqlDataReader reader=SqlHelper.ExecuteReader(constr))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        userID model = new userID();
                        model.numberStu = reader.GetInt32(0);
                        model.nameStu = reader.IsDBNull(1)?null:reader.GetString(1);
                        model.scoreStu = reader.GetInt32(2);
                        model.dataStu = reader.GetDateTime(3);
                        model.courseStu = reader.GetString(4);
                        list.Add(model);
                    }
                }
            }
            MessageBox.Show(list.Count.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
