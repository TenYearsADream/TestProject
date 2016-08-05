using SqlHelperClass;
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

namespace CityChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProvince();
        }

        private void LoadProvince()
        {
            //List<TblArea> list=new List<TblArea>();
            string sql = "select AreaId,AreaName from TblArea where AreaPId=@Pid";
            SqlParameter p1=new SqlParameter("@Pid",SqlDbType.Int) {Value=0};
            using(SqlDataReader reader=SqlHelper.ExecuteReader(sql,p1))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        //comboBox1.Items.Add(reader.GetString(1));
                        TblArea model = new TblArea();
                        model.AreaID = reader.GetInt32(0);
                        model.AreaName = reader.GetString(1);

                        comboBox1.Items.Add(model);
                    }
                }
            }
        }
        //显示当前选中的省份的名称和ID
        private void button1_Click(object sender, EventArgs e)
        {
            //if(comboBox1.Text.Trim().Length>0)
            //{

            //}
            if(comboBox1.SelectedItem!=null)
            {
                TblArea model = (TblArea)comboBox1.SelectedItem;
                MessageBox.Show(model.AreaName + "   " + model.AreaID);
            }
        }
        //选择项改变事件
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.获取当前省份的id
            if (comboBox1.SelectedItem != null)
            {
                //comboBox2.Items.Clear();
                TblArea model = comboBox1.SelectedItem as TblArea;
                int areaId = model.AreaID;
                //根据areaID从数据库中查询对应的数据
                List<TblArea> cities = GetSubCity(areaId);
                //方式1：向下拉菜单中增加数据
                //foreach (TblArea item in cities)
                //{
                //    comboBox2.Items.Add(item);
                //}
                //方式二 通过数据绑定
                //建议绑定数据源 的时候先设置displayMember
                comboBox2.DisplayMember = "AreaName";
                comboBox2.ValueMember = "AreaID";
                comboBox2.DataSource = cities;
            }                       
        }
        private List<TblArea> GetSubCity(int areaId)
        {
            List<TblArea> list = new List<TblArea>();
            string sql = "select AreaId,AreaName from TblArea where AreaPId=@id";
            SqlParameter p1=new SqlParameter("@id",SqlDbType.Int){Value=areaId};
            using(SqlDataReader reader=SqlHelper.ExecuteReader(sql,p1))
            {
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        TblArea model = new TblArea();
                        model.AreaID = reader.GetInt32(0);
                        model.AreaName = reader.GetString(1);
                        list.Add(model);
                    }
                }
            }
            return list;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text + "  " + comboBox2.SelectedValue.ToString());
        }
    }
}
