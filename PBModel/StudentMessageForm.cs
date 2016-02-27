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
	public partial class StudentMessageForm : Form
	{
		SqlConnection conn = new SqlConnection("server=.;integrated security=true;database=student");
		DataSet ds = new DataSet();
		SqlDataAdapter dtp;
		public StudentMessageForm()
		{
			InitializeComponent();
		}
		//只读更改为可更改
		private void add_Click(object sender, EventArgs e)
		{
			studentMessage.ReadOnly = false;
			studentMessage.AllowUserToAddRows = true;
		}
		//显示记录数
		private void StudentMessageForm_Load(object sender, EventArgs e)
		{
			studentMessage.ReadOnly = true;
			studentMessage.AllowUserToAddRows = false;
			conn.Open();
			dtp = new SqlDataAdapter("select * from S", conn);
			dtp.Fill(ds,"s");
			studentMessage.DataSource = ds.Tables["s"];
			number.Text = ds.Tables["s"].Rows.Count.ToString();
			conn.Close(); 
		}
		//保存,这里需要更新数据库
		private void save_Click(object sender, EventArgs e)
		{
			if (ds.HasChanges())
			{
				SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
				dtp.Update(ds,"s");//注意这里更新的表为form_load里面的表注意这里就可以成功
				studentMessage.Update();
			}
			dtp = new SqlDataAdapter("select * from S", conn);
			dtp.Fill(ds, "save");
			studentMessage.DataSource = ds.Tables["save"];
			studentMessage.ReadOnly = true;
			studentMessage.AllowUserToAddRows = false;
		}

		private void exist_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void delete_Click(object sender, EventArgs e)
		{
			//点击
			//手动删除之后，更新数据库
			int line = this.studentMessage.CurrentRow.Index;
			String primary = this.studentMessage.Rows[line].Cells[0].Value.ToString();
			conn.Open();
			dtp = new SqlDataAdapter("delete from S where sno = '" + primary + "'", conn);
			dtp.Fill(ds, "delete");
			studentMessage.DataSource = ds.Tables["delete"];
			SqlDataAdapter deleteDtp = new SqlDataAdapter("select * from S", conn);
			deleteDtp.Fill(ds, "fresh");
			studentMessage.DataSource = ds.Tables["fresh"];
			//MessageBox.Show(primary);
			conn.Close();
			studentMessage.ReadOnly = false;
			studentMessage.AllowUserToAddRows = true;
		}
	}
}
