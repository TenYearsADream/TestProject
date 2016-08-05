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
    public partial class 递归加载 : Form
    {
        public 递归加载()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadAreastotree(0, this.treeView1.Nodes);
        }
        //将制定的I的下的节点加载到nodes集合中
        private void loadAreastotree(int pid, TreeNodeCollection treeNodeCollection)
        {
            //1 根据pid查询下面的所有的子城市
            List<TblArea> list = GetAreasByParentId(pid);
            //2 把这些城市加载到Tree中
            foreach(TblArea item in list)
            {
                TreeNode node = treeNodeCollection.Add(item.AreaName);
                node.Tag = item.AreaID;
                loadAreastotree(item.AreaID, node.Nodes);
            }
        }
        private List<TblArea> GetAreasByParentId(int pid)
        {
            List<TblArea> list = new List<TblArea>();
            string sql = "select AreaId,AreaName from TblArea where AreaPId=@pid";
            SqlParameter p1 = new SqlParameter("@pid", SqlDbType.Int) { Value = pid };
            using (SqlDataReader reader = SqlHelper.ExecuteReader(sql, p1))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
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

        private void 递归加载_Load(object sender, EventArgs e)
        {

        }
    }
}
