﻿using System;
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
		public StudentMessageForm()
		{
			InitializeComponent();
		}
		//只读更改为可更改
		private void add_Click(object sender, EventArgs e)
		{
			studentMessage.ReadOnly = false;
		}
		//显示记录数
		private void StudentMessageForm_Load(object sender, EventArgs e)
		{
			studentMessage.ReadOnly = true;
			conn.Open();
			SqlDataAdapter dtp = new SqlDataAdapter("select * from S", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds);
			number.Text = ds.Tables["s"].Rows.Count.ToString();//某一表中数据的行数
			
			conn.Close(); 
		}
		//保存
		private void save_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlDataAdapter dtp = new SqlDataAdapter("select * from S", conn);
			DataSet ds = new DataSet();
			dtp.Fill(ds);
			studentMessage.DataSource = ds.Tables[0];
			SqlCommandBuilder builder = new SqlCommandBuilder(dtp);
			dtp.Update(ds.Tables[0]);
			ds.Tables[0].AcceptChanges();
			conn.Close();
		}

		private void exist_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}