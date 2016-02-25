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
	//系统登录到这个界面之后可以通过查询在label上面显示该教师所授课程和教师姓名
	public partial class CourseForm : Form
	{
		SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
		public CourseForm()
		{
			InitializeComponent();
		}

		//点击查询后在选修此课程中显示学号和成绩（成绩如果没有显示为空）
		private void select_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlDataAdapter dtp = new SqlDataAdapter("select sno,grade from SC where cno=(select cno from c where cname='"+courseChoose.Text.Trim()+"')", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds,"select");
			showStudent.DataSource = ds.Tables["select"];
			conn.Close();
		}

		//点击输入成绩按钮之后，可以在datagridview中插入成绩，同时按钮变为保存，点击即可将数据保存到数据库
		//同时，查询、成绩分布和退出按钮失效，在按下保存按钮之后，按钮恢复到原来状态
		private void input_Click(object sender, EventArgs e)
		{
			if (input.Text.Equals("输入成绩"))
			{
				showStudent.ReadOnly = false;
				input.Text = "保存";
				select.Enabled = false;
				grade.Enabled = false;
				exist.Enabled = false;
			}
			else
			{
				conn.Open();
				//datagridviews数据更新操作
				input.Text = "输入成绩";
				select.Enabled = true;
				grade.Enabled = true;
				exist.Enabled = true;
				SqlDataAdapter dtp = new SqlDataAdapter("select sno,grade from SC where cno=(select cno from c where cname='" + courseChoose.Text.Trim() + "')", conn);
				DataSet ds = new DataSet();
				dtp.Fill(ds,"save");
				showStudent.DataSource = ds.Tables["save"];
				SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
				//dtp.UpdateCommand = builder.GetUpdateCommand();
				DataTable dt = ds.Tables["save"];
				dt.PrimaryKey = new DataColumn[] { dt.Columns["sno"], dt.Columns["cno"] };

				dtp.Update(dt);
				ds.Tables["save"].AcceptChanges();
				//dtp.Update(ds.Tables["save"]);
				//ds.Tables["save"].AcceptChanges();
				//dtp.Update(ds.Tables["save"]);
				//showStudent.Update();

				//更新之后再次查询
				SqlDataAdapter dtpSelect = new SqlDataAdapter("select sno,grade from SC where cno=(select cno from c where cname='" + courseChoose.Text.Trim() + "')", conn);
				DataSet dsSelect = new DataSet();
				dtp.Fill(ds, "select1");
				showStudent.DataSource = ds.Tables["select1"];
				showStudent.ReadOnly = true;
				conn.Close();
			}
			
		}

		//点击成绩分布按钮，进入到成绩分布主窗口
		private void grade_Click(object sender, EventArgs e)
		{
			GradeDistribute ds = new GradeDistribute();
			ds.Show();
			//this.Hide();
		}

		private void exist_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//点击维护跳转到学生信息和课程信息窗口
		private void maintain_Click(object sender, EventArgs e)
		{
			String strMessage = maintainBox.SelectedItem.ToString();
			if (strMessage.Equals("课程信息"))
			{
				CourseMessageForm course = new CourseMessageForm();
				course.Show();
			}
			else
			{
				StudentMessageForm stuMessage = new StudentMessageForm();
				stuMessage.Show();
			}
		}

		private void CourseForm_Load(object sender, EventArgs e)
		{
			showStudent.ReadOnly = true;
			conn.Open();

			maintainBox.Items.Add("学生信息");
			maintainBox.Items.Add("课程信息");
			maintainBox.SelectedIndex = 0;
			//courseChoose显示课程名
			SqlDataAdapter dtp = new SqlDataAdapter("select cname from c", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds,"c");
			courseChoose.DataSource = ds.Tables["c"];
			courseChoose.DisplayMember = "cname";

			courseName.Text = courseChoose.Text;
			SqlDataAdapter selectMessage = new SqlDataAdapter("select tname from c where cname='" + courseChoose.Text + "'", conn);
			selectMessage.Fill(ds, "message");
			DataRow dr = ds.Tables["message"].Rows[0];
			teacherName.Text = dr["tname"].ToString();
			conn.Close();
		}
		//鼠标单击combobox里面内容
		private void courseChoose_MouseClick(object sender, MouseEventArgs e)
		{
			courseName.Text = courseChoose.Text;
			conn.Open();

			SqlDataAdapter dtp = new SqlDataAdapter("select tname from c where cname='"+courseChoose.Text+"'", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds, "c");
			DataRow dr = ds.Tables[0].Rows[0];
			teacherName.Text = dr["tname"].ToString();

			conn.Close();
		}

		
	}
}
