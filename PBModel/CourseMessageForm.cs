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
	public partial class CourseMessageForm : Form
	{
		SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
		public CourseMessageForm()
		{
			InitializeComponent();
		}

		private void add_Click(object sender, EventArgs e)
		{
			courseMessage.ReadOnly = false;
		}

		private void save_Click(object sender, EventArgs e)
		{
			SqlDataAdapter dtp = new SqlDataAdapter();
			dtp.SelectCommand = new SqlCommand("select * from C", conn);
			SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
			conn.Open();
			DataSet ds = new DataSet();
			dtp.Fill(ds,"course");
			//courseMessage.DataSource = ds.Tables["course"];
			dtp.InsertCommand = builder.GetInsertCommand();
			dtp.Update(ds,"course");
			//ds.Tables[0].AcceptChanges();

			
			//SqlDataAdapter dtpCourse = new SqlDataAdapter("select * from c", conn);
			////DataSet ds = new DataSet();
			//dtp.Fill(ds, "c");
			//courseMessage.DataSource = ds.Tables["c"];
			//number.Text = ds.Tables["c"].Rows.Count.ToString();//某一表中数据的行数
			conn.Close();
		}

		private void delete_Click(object sender, EventArgs e)
		{
			SqlDataAdapter dtp = new SqlDataAdapter("select * from c",conn);
			courseMessage.Rows.RemoveAt(courseMessage.CurrentCell.RowIndex);
			SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
			conn.Open();
			DataSet ds = new DataSet();
			dtp.Fill(ds, "delete");
			dtp.Update(ds.Tables["delete"]);
			conn.Close();
			//待定，手动删除之后需要更新数据库
		}

		private void exist_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CourseMessageForm_Load(object sender, EventArgs e)
		{
			courseMessage.ReadOnly = true;
			conn.Open();
			SqlDataAdapter dtp = new SqlDataAdapter("select * from c", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds, "c");
			courseMessage.DataSource = ds.Tables["c"];
			number.Text = ds.Tables["c"].Rows.Count.ToString();//某一表中数据的行数

			conn.Close(); 
		}
	}
}
