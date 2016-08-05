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

namespace sqlWinfrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            List<Class122> list = new List<Class122>();
            string constr = "data source=SHZB-WANGXF2-DP\\MSSQL;initial catalog=MyFirstDatabase;integrated security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = "select * from dbo.Class122";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //如果表格数据有null值
                                //model.nameStu = reader.IsDBNull(2) ? null : reader.GetString(2);
                                //学号, 姓名, 成绩, 入学日期, 主修课程
                                Class122 model = new Class122();
                                model.numberStu = reader.GetInt32(0);
                                model.nameStu = reader.GetString(1);
                                model.scoreStu = reader.GetInt32(2);
                                model.dataStu = reader.GetDateTime(3);
                                model.courseStu = reader.GetString(4);
                                list.Add(model);
                            }
                        }
                    }
                }
            }
            //数据绑定需要注意一点
            //1.数据绑定只认属性，不认字段  反射实现  只获取属性不获取字段
            this.dataGridView1.DataSource = list;//数据绑定
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            #region 版本1
            ////1.采集用户的输入
            ////姓名, 成绩, 入学日期, 主修课程
            //string className = textBox1.Text.Trim();
            //int classScore = Convert.ToInt32(textBox2.Text.Trim());//trim去掉前后空格
            //string classData = textBox4.Text.Trim();
            //string classCourse = textBox3.Text.Trim();
            ////2 执行插入操作
            //string constr = "data source=DESKTOP-OIJACEC;initial catalog=MyFirstDatabase;integrated security=true";
            //using (SqlConnection con = new SqlConnection(constr))
            //{
            //    string sql = string.Format("insert into dbo.Class122 values(N'{0}',{1},N'{2}',N'{3}')", className, classScore, classData, classCourse);
            //    using (SqlCommand cmd = new SqlCommand(sql, con))
            //    {
            //        con.Open();
            //        int r = cmd.ExecuteNonQuery();
            //        if (r > 0)
            //        {
            //            this.Text = "插入成功";
            //            LoadData();
            //            //MessageBox.Show("插入成功");
            //        }
            //        else
            //        {
            //            this.Text = "插入" + r + "行";
            //            //MessageBox.Show("插入"+r+"行");
            //        }
            //    }
            //}
            #endregion
            #region 版本二
            //1.采集用户的输入
            //姓名, 成绩, 入学日期, 主修课程
            int classStu = Convert.ToInt32(textBox9.Text.Trim());
            string className = textBox1.Text.Trim();
            int classScore = Convert.ToInt32(textBox2.Text.Trim());//trim去掉前后空格
            string classData = textBox4.Text.Trim();
            string classCourse = textBox3.Text.Trim();
            //2 执行插入操作
            string constr = "data source=SHZB-WANGXF2-DP\\MSSQL;initial catalog=MyFirstDatabase;integrated security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("insert into dbo.Class122 output inserted.学号 values({0},{1},{2},N'{3}',{4})", classStu, className, classScore, classData, classCourse);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    object obj=cmd.ExecuteScalar();
                    this.Text = "刚刚插入的记录的自动编号是："+obj.ToString();
                    LoadData();
                }
            }
            #endregion
        }
        //行获取焦点事件
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //获取当前选中行的对象
            DataGridViewRow currentRow = this.dataGridView1.Rows[e.RowIndex];
            //获取当前行中绑定的数据对象
            //转换失败就返回null
            Class122 model = currentRow.DataBoundItem as Class122;
            if (model != null)
            {
                label10.Text = model.numberStu.ToString();
                textBox8.Text = model.nameStu;
                textBox7.Text = model.scoreStu.ToString();
                textBox6.Text = model.dataStu.ToLongDateString();
                textBox5.Text = model.courseStu;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ModifyData_Click(object sender, EventArgs e)
        {
            //1.采集用户输入
            Class122 model = new Class122();
            model.numberStu = Convert.ToInt32(label10.Text);
            model.nameStu = textBox8.Text.Trim();
            model.scoreStu = Convert.ToInt32(textBox7.Text);
            model.dataStu = Convert.ToDateTime(textBox6.Text);
            model.courseStu = textBox5.Text;
            //连接数据库
            string constr = "data source=SHZB-WANGXF2-DP\\MSSQL;initial catalog=MyFirstDatabase;integrated security=true";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string sql = string.Format("update dbo.Class122 set 姓名='{0}', 成绩={1}, 入学日期='{2}', 主修课程='{3}' where 学号={4}", model.nameStu, model.scoreStu, model.dataStu, model.courseStu, model.numberStu);
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        this.Text = "更新了" + r + "行";
                        LoadData();
                    }
                }
            }
        }
        private void DeleteData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要删除吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                int numberID = Convert.ToInt32(label10.Text);

                string constr = "data source=SHZB-WANGXF2-DP\\MSSQL;initial catalog=MyFirstDatabase;integrated security=true";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql = string.Format("delete from dbo.Class122 where 学号={0}", numberID);
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        con.Open();
                        int r = cmd.ExecuteNonQuery();
                        if (r > 0)
                        {
                            this.Text = "删除了" + r + "行";
                            LoadData();
                        }
                    }
                }
            }           
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
