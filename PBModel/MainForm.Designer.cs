namespace PBModel
{
	partial class MainForm
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
			this.chooseCourse = new System.Windows.Forms.Button();
			this.dropCourse = new System.Windows.Forms.Button();
			this.close = new System.Windows.Forms.Button();
			this.courseNumber = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.studentMessage = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.choosedCourse = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.canChooseCourse = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.selectedCourse = new System.Windows.Forms.DataGridView();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentMessage)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.choosedCourse)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.canChooseCourse)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.selectedCourse)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// chooseCourse
			// 
			this.chooseCourse.Location = new System.Drawing.Point(85, 82);
			this.chooseCourse.Name = "chooseCourse";
			this.chooseCourse.Size = new System.Drawing.Size(62, 23);
			this.chooseCourse.TabIndex = 0;
			this.chooseCourse.Text = "选课";
			this.chooseCourse.UseVisualStyleBackColor = true;
			this.chooseCourse.Click += new System.EventHandler(this.chooseCourse_Click);
			// 
			// dropCourse
			// 
			this.dropCourse.Location = new System.Drawing.Point(85, 138);
			this.dropCourse.Name = "dropCourse";
			this.dropCourse.Size = new System.Drawing.Size(62, 23);
			this.dropCourse.TabIndex = 1;
			this.dropCourse.Text = "退课";
			this.dropCourse.UseVisualStyleBackColor = true;
			this.dropCourse.Click += new System.EventHandler(this.dropCourse_Click);
			// 
			// close
			// 
			this.close.Location = new System.Drawing.Point(85, 190);
			this.close.Name = "close";
			this.close.Size = new System.Drawing.Size(62, 23);
			this.close.TabIndex = 2;
			this.close.Text = "关闭";
			this.close.UseVisualStyleBackColor = true;
			// 
			// courseNumber
			// 
			this.courseNumber.Location = new System.Drawing.Point(6, 34);
			this.courseNumber.Name = "courseNumber";
			this.courseNumber.Size = new System.Drawing.Size(87, 21);
			this.courseNumber.TabIndex = 8;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.studentMessage);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(223, 161);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "学生详细信息：";
			// 
			// studentMessage
			// 
			this.studentMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentMessage.Location = new System.Drawing.Point(6, 20);
			this.studentMessage.Name = "studentMessage";
			this.studentMessage.RowTemplate.Height = 23;
			this.studentMessage.Size = new System.Drawing.Size(211, 124);
			this.studentMessage.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.choosedCourse);
			this.groupBox2.Location = new System.Drawing.Point(13, 216);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(222, 161);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "已选修课程：";
			// 
			// choosedCourse
			// 
			this.choosedCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.choosedCourse.Location = new System.Drawing.Point(5, 20);
			this.choosedCourse.Name = "choosedCourse";
			this.choosedCourse.RowTemplate.Height = 23;
			this.choosedCourse.Size = new System.Drawing.Size(211, 124);
			this.choosedCourse.TabIndex = 14;
			this.choosedCourse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.choosedCourse_CellDoubleClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.canChooseCourse);
			this.groupBox3.Location = new System.Drawing.Point(263, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(223, 161);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "可选课程：";
			// 
			// canChooseCourse
			// 
			this.canChooseCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.canChooseCourse.Location = new System.Drawing.Point(6, 20);
			this.canChooseCourse.Name = "canChooseCourse";
			this.canChooseCourse.RowTemplate.Height = 23;
			this.canChooseCourse.Size = new System.Drawing.Size(211, 124);
			this.canChooseCourse.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.selectedCourse);
			this.groupBox4.Location = new System.Drawing.Point(263, 216);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(223, 161);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "已选课程：";
			// 
			// selectedCourse
			// 
			this.selectedCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.selectedCourse.Location = new System.Drawing.Point(6, 20);
			this.selectedCourse.Name = "selectedCourse";
			this.selectedCourse.RowTemplate.Height = 23;
			this.selectedCourse.Size = new System.Drawing.Size(211, 124);
			this.selectedCourse.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.close);
			this.groupBox5.Controls.Add(this.chooseCourse);
			this.groupBox5.Controls.Add(this.dropCourse);
			this.groupBox5.Controls.Add(this.courseNumber);
			this.groupBox5.Location = new System.Drawing.Point(492, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(165, 348);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "输入课程号：";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 389);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "学生选课";
			
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.studentMessage)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.choosedCourse)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.canChooseCourse)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.selectedCourse)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button chooseCourse;
		private System.Windows.Forms.Button dropCourse;
		private System.Windows.Forms.Button close;
		private System.Windows.Forms.TextBox courseNumber;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView studentMessage;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView choosedCourse;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView canChooseCourse;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView selectedCourse;
		private System.Windows.Forms.GroupBox groupBox5;
	}
}