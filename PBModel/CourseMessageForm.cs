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
			courseMessage.ReadOnly = true;
		}

		private void save_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlDataAdapter dtp = new SqlDataAdapter("select * from C", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds);
			courseMessage.DataSource = ds.Tables[0];
			SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
			dtp.Update(ds.Tables[0]);
			ds.Tables[0].AcceptChanges();
			conn.Close();
		}

		private void delete_Click(object sender, EventArgs e)
		{
			//待定
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
			dtp.Fill(ds);
			number.Text = ds.Tables["c"].Rows.Count.ToString();//某一表中数据的行数

			conn.Close(); 
		}
	}
}
