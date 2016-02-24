namespace PBModel
{
	partial class CourseMessageForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.number = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.exist = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.courseMessage = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.courseMessage)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "记录总数";
			// 
			// number
			// 
			this.number.AutoSize = true;
			this.number.Location = new System.Drawing.Point(133, 28);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(77, 12);
			this.number.TabIndex = 1;
			this.number.Text = "用来记录总数";
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(32, 15);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 2;
			this.add.Text = "新增";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(32, 65);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 3;
			this.save.Text = "保存";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(32, 113);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 4;
			this.delete.Text = "删除";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// exist
			// 
			this.exist.Location = new System.Drawing.Point(32, 161);
			this.exist.Name = "exist";
			this.exist.Size = new System.Drawing.Size(75, 23);
			this.exist.TabIndex = 5;
			this.exist.Text = "退出";
			this.exist.UseVisualStyleBackColor = true;
			this.exist.Click += new System.EventHandler(this.exist_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.courseMessage);
			this.groupBox1.Location = new System.Drawing.Point(12, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(257, 192);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// courseMessage
			// 
			this.courseMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.courseMessage.Location = new System.Drawing.Point(6, 15);
			this.courseMessage.Name = "courseMessage";
			this.courseMessage.RowTemplate.Height = 23;
			this.courseMessage.Size = new System.Drawing.Size(245, 169);
			this.courseMessage.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.add);
			this.groupBox2.Controls.Add(this.exist);
			this.groupBox2.Controls.Add(this.delete);
			this.groupBox2.Controls.Add(this.save);
			this.groupBox2.Location = new System.Drawing.Point(288, 54);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(131, 192);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// CourseMessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 271);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.number);
			this.Controls.Add(this.label1);
			this.Name = "CourseMessageForm";
			this.Text = "课程信息";
			this.Load += new System.EventHandler(this.CourseMessageForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.courseMessage)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label number;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button exist;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView courseMessage;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}