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

	
	public partial class MainForm : Form
	{
		

		SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
		String text;
		public MainForm(String userName)
		{
			text = userName;
			InitializeComponent();
		}
		
		private void MainForm_Load(object sender, EventArgs e)
		{
			conn.Open();

			SqlDataAdapter dtp = new SqlDataAdapter("select sno,sname,sex,age,sdept from S where logn='" + text + "'", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds);
			studentMessage.DataSource = ds.Tables[0];


			//SqlDataAdapter chooseDtp = new SqlDataAdapter("", conn);//查找已经选修的课程
			//chooseDtp.Fill(ds);
			//choosedCourse.DataSource = ds.Tables[0].DefaultView;

			//SqlDataAdapter canChooseDtp = new SqlDataAdapter("", conn);//查找可选课程
			//canChooseDtp.Fill(ds);
			//canChooseCourse.DataSource = ds.Tables[0].DefaultView;

			//SqlDataAdapter selectedDtp = new SqlDataAdapter("", conn);//查询已经选的课程
			//selectedDtp.Fill(ds);
			//selectedCourse.DataSource = ds.Tables[0].DefaultView;

			conn.Close();

		}

		//点击选课按钮之后重新更新已经选的课程
		private void chooseCourse_Click(object sender, EventArgs e)
		{
			String course = courseNumber.Text;
			//将新课程添加进去，然后再重新查询
			SqlDataAdapter dtp = new SqlDataAdapter("", conn);//查询已经选的课程
			DataSet ds = new DataSet();
			dtp.Fill(ds);
			studentMessage.DataSource = ds.Tables[0].DefaultView;
		}

		//点击退课按钮之后，删除数据库中的信息，然后重新查询
		private void dropCourse_Click(object sender, EventArgs e)
		{

		}

		//双击连接到学生成绩单
		private void choosedCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			StudentGradeForm stu = new StudentGradeForm(text);
			stu.Show();
			this.Hide();
		}

		

		
	}
}
