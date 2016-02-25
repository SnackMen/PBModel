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
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			
			InitializeComponent();
		}

		private void login_Click(object sender, EventArgs e)
		{
			
			//要求输入学生学号和密码之后进入数据库查询，将查询结果保存一并进入下一个窗口
			//以下为虚构
			SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
			conn.Open();
			SqlCommand cmd = new SqlCommand("select logn from s where logn='"+userName.Text+"'",conn);
			SqlDataReader sqlr = cmd.ExecuteReader();
			if (sqlr.Read())
			{
				MainForm mainform = new MainForm(userName.Text);
				mainform.Show();
				this.Hide();
			}
			else if (userName.Text == "admin" && password.Text == "admin")
			{
				CourseForm course = new CourseForm();
				course.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("请输入正确账号与密码！！！");
			}
		}

		private void exist_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
