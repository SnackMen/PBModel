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
	//查询数据，显示在graridview
	public partial class StudentGradeForm : Form
	{
		SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
		String text;
		public StudentGradeForm(String sNo)
		{
			text = sNo;
			InitializeComponent();
		}
		//综合查询
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			conn.Open();
			SqlDataAdapter dtp = new SqlDataAdapter("select distinct c.cno,cname,grade,credit,tname from c,sc,s where s.sno=sc.sno and s.sno='"+text+"'"+" and c.cno=sc.cno", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds);
			studentGrade.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void StudentGradeForm_Load(object sender, EventArgs e)
		{
			conn.Open();
			number.Text = text;
			SqlCommand cmd = new SqlCommand("select sname from s where sno='"+text+"'", conn);
			SqlDataReader sqlr = cmd.ExecuteReader();
			name.Text = sqlr.GetString(1);//第二列
			conn.Close();

		}
	}
}
