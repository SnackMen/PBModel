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
			//显示学生详细信息
			SqlDataAdapter dtp = new SqlDataAdapter("select sno,sname,sex,age,sdept from S where logn='" + text + "'", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds);//放到第一个表里面储存
			studentMessage.DataSource = ds.Tables[0];
			//conn.Close();

			//已选修课程
			//conn.Open();
			SqlDataAdapter chooseDtp = new SqlDataAdapter("select c.cno,cname,grade from c,sc where sno='"+text+"'"+" and c.cno= sc.cno", conn);//查找已经选修的课程
			chooseDtp.Fill(ds,"1");//放到表名为"1"的表中储存，虚拟表，自己随便起名字
			choosedCourse.DataSource = ds.Tables["1"];


			//可选课程
			SqlDataAdapter canChooseDtp = new SqlDataAdapter("select cno,cname from c where cno not in(select cno from selecteds where sno='"+text+"') and c.cno not in (select cno from hasselect )", conn);//查找可选课程
			canChooseDtp.Fill(ds,"2");
			canChooseCourse.DataSource = ds.Tables["2"];

			//查询已选课程
			SqlDataAdapter selectedDtp = new SqlDataAdapter("select cno,cname,credit,cdept,tname from hasselect where sno='"+text+"'", conn);//查询已经选的课程
			selectedDtp.Fill(ds,"3");
			selectedCourse.DataSource = ds.Tables["3"];

			conn.Close();

		}

		//点击选课按钮之后重新更新已经选的课程
		private void chooseCourse_Click(object sender, EventArgs e)
		{
			String course = courseNumber.Text;
			conn.Open();
			DataSet ds = new DataSet();

			SqlCommand sqc = new SqlCommand("select cno from c where cno not in(select cno from selecteds where sno='" + text + "') and c.cno not in (select cno from hasselect )", conn);
			SqlDataReader reader = sqc.ExecuteReader();
			while (reader.Read())
			{
				if (reader["cno"].ToString().Trim().Equals(course))
				{
					reader.Close();
					//查找存在
					SqlDataAdapter insertHasselect1 = new SqlDataAdapter("insert into hasselect(sno,cno,cname,credit,cdept,Tname) select sno,cno,cname,credit,cdept,tname from c,s where CNO='" + course + "' and SNO='" + text + "'", conn);
					insertHasselect1.Fill(ds, "5");
					//selectedCourse.DataSource = ds.Tables["5"];

					SqlDataAdapter insertHasselect2 = new SqlDataAdapter("select cno,cname,credit,cdept,tname from hasselect where sno='" + text + "'", conn);//查询已经选的课程
					insertHasselect2.Fill(ds, "6");
					selectedCourse.DataSource = ds.Tables["6"];

					SqlDataAdapter canChooseDtp = new SqlDataAdapter("select cno,cname from c where cno not in(select cno from selecteds where sno='" + text + "') and c.cno not in (select cno from hasselect )", conn);//查找可选课程
					canChooseDtp.Fill(ds, "7");
					canChooseCourse.DataSource = ds.Tables["7"];
					break;

				}
				
			}
				conn.Close();
		}

		//点击退课按钮之后，删除数据库中的信息，然后重新查询
		private void dropCourse_Click(object sender, EventArgs e)
		{
			String course = courseNumber.Text;
			conn.Open();
			DataSet ds = new DataSet();
			SqlDataAdapter insertHasselect1 = new SqlDataAdapter("delete from hasselect where CNO='" + course + "'", conn);
			insertHasselect1.Fill(ds, "8");

			SqlDataAdapter insertHasselect2 = new SqlDataAdapter("select cno,cname,credit,cdept,tname from hasselect where sno='" + text + "'", conn);//查询已经选的课程
			insertHasselect2.Fill(ds, "9");
			selectedCourse.DataSource = ds.Tables["9"];

			SqlDataAdapter canChooseDtp = new SqlDataAdapter("select cno,cname from c where cno not in(select cno from selecteds where sno='" + text + "') and c.cno not in (select cno from hasselect )", conn);//查找可选课程
			canChooseDtp.Fill(ds, "10");
			canChooseCourse.DataSource = ds.Tables["10"];
			conn.Close();
		}

		//双击连接到学生成绩单
		private void choosedCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			StudentGradeForm stu = new StudentGradeForm(text);
			stu.Show();
			this.Hide();
		}

		private void close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
