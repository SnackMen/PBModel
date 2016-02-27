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
		SqlDataAdapter dtp;
		DataSet ds = new DataSet();
		public CourseMessageForm()
		{
			InitializeComponent();	
		}

		private void add_Click(object sender, EventArgs e)
		{
			courseMessage.ReadOnly = false;
			courseMessage.AllowUserToAddRows = true;
		}

		private void save_Click(object sender, EventArgs e)
		{
			//conn.Open();
			if (ds.HasChanges())
			{
				SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
				dtp.Update(ds, "c");//注意这里更新的表为form_load里面的表注意这里就可以成功
				courseMessage.Update();
			}
			dtp = new SqlDataAdapter("select * from C", conn);
			dtp.Fill(ds, "save");
			courseMessage.DataSource = ds.Tables["save"];
			courseMessage.ReadOnly = true;
			courseMessage.AllowUserToAddRows = false;
			//conn.Close();
		}

		private void delete_Click(object sender, EventArgs e)
		{
			int line = this.courseMessage.CurrentRow.Index;
			String primary = this.courseMessage.Rows[line].Cells[0].Value.ToString();
			conn.Open();
			dtp = new SqlDataAdapter("delete from C where cno = '" + primary + "'", conn);
			dtp.Fill(ds, "delete");
			courseMessage.DataSource = ds.Tables["delete"];
			SqlDataAdapter deleteDtp = new SqlDataAdapter("select * from C", conn);
			deleteDtp.Fill(ds, "fresh");
			courseMessage.DataSource = ds.Tables["fresh"];
			courseMessage.ReadOnly = false;
			courseMessage.AllowUserToAddRows = true;
			//MessageBox.Show(primary);
			conn.Close();
			courseMessage.ReadOnly = true;
			courseMessage.AllowUserToAddRows = false;
		}

		private void exist_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CourseMessageForm_Load(object sender, EventArgs e)
		{
			courseMessage.ReadOnly = true;
			courseMessage.AllowUserToAddRows = false;
			conn.Open();
			dtp = new SqlDataAdapter("select * from c", conn);
			dtp.Fill(ds, "c");
			courseMessage.DataSource = ds.Tables["c"];
			number.Text = ds.Tables["c"].Rows.Count.ToString();//某一表中数据的行数
			conn.Close(); 
		}
	}
}
