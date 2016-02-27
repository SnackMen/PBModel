using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PBModel
{
	public partial class GradeDistribute : Form
	{
		SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
		DataSet ds = new DataSet();
		SqlDataAdapter dtp;
		String course;
		public GradeDistribute(String text)
		{
			course = text;
			InitializeComponent();
		}

		private void GradeDistribute_Load(object sender, EventArgs e)
		{
			//横轴：学号
			//纵轴: 分数
			//图表的分度值为 10
			//具体思路：
			/*通过查询语句将数据库中的学号和对应姓名分别放到一个表的轴里面
			 * 然后利用循环来实现添加
			 */
			//创建chart控件
			DataTable dt = default(DataTable);
			dt = CreateDataTable();
			grade.DataSource = dt;
			grade.Series[0].YValueMembers = "GRADE";
			grade.Series[0].XValueMember = "SNO";
			grade.DataBind();
			
		}
		private DataTable CreateDataTable()
		{
			DataTable dt = new DataTable();
			dtp = new SqlDataAdapter("select sno,grade from SC where cno=(select cno from c where cname='" + course.Trim() + "')", conn);
			dtp.Fill(ds);
			//DataTable dt = ds.Tables[0];
			dt.Columns.Add("SNO");
			dt.Columns.Add("GRADE");
			
			for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
			{
				DataRow dr = dt.NewRow();
				dr["SNO"] = ds.Tables[0].Rows[i][0].ToString();
				String student = ds.Tables[0].Rows[i][1].ToString();
				dr["GRADE"] = Int32.Parse(student);
				dt.Rows.Add(dr);
			}
				return dt;
		}
	}
}
