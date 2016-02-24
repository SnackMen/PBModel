namespace PBModel
{
	partial class StudentMessageForm
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
			this.add = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.exist = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.number = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.studentMessage = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentMessage)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(28, 12);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 0;
			this.add.Text = "新增";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(28, 55);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(75, 23);
			this.save.TabIndex = 1;
			this.save.Text = "保存";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// delete
			// 
			this.delete.Location = new System.Drawing.Point(28, 97);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 2;
			this.delete.Text = "删除";
			this.delete.UseVisualStyleBackColor = true;
			// 
			// exist
			// 
			this.exist.Location = new System.Drawing.Point(28, 139);
			this.exist.Name = "exist";
			this.exist.Size = new System.Drawing.Size(75, 23);
			this.exist.TabIndex = 3;
			this.exist.Text = "退出";
			this.exist.UseVisualStyleBackColor = true;
			this.exist.Click += new System.EventHandler(this.exist_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "记录总数";
			// 
			// number
			// 
			this.number.AutoSize = true;
			this.number.Location = new System.Drawing.Point(129, 30);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(77, 12);
			this.number.TabIndex = 5;
			this.number.Text = "用来记录总数";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.studentMessage);
			this.groupBox1.Location = new System.Drawing.Point(12, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 170);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// studentMessage
			// 
			this.studentMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentMessage.Location = new System.Drawing.Point(6, 14);
			this.studentMessage.Name = "studentMessage";
			this.studentMessage.RowTemplate.Height = 23;
			this.studentMessage.Size = new System.Drawing.Size(223, 150);
			this.studentMessage.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.add);
			this.groupBox2.Controls.Add(this.save);
			this.groupBox2.Controls.Add(this.delete);
			this.groupBox2.Controls.Add(this.exist);
			this.groupBox2.Location = new System.Drawing.Point(282, 58);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(141, 168);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// StudentMessageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 262);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.number);
			this.Controls.Add(this.label1);
			this.Name = "StudentMessageForm";
			this.Text = "学生信息";
			this.Load += new System.EventHandler(this.StudentMessageForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.studentMessage)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button exist;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label number;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView studentMessage;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}