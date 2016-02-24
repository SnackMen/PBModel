namespace PBModel
{
	partial class CourseForm
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
			this.courseName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.teacherName = new System.Windows.Forms.Label();
			this.select = new System.Windows.Forms.Button();
			this.input = new System.Windows.Forms.Button();
			this.grade = new System.Windows.Forms.Button();
			this.exist = new System.Windows.Forms.Button();
			this.courseChoose = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.showStudent = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.maintainBox = new System.Windows.Forms.ComboBox();
			this.maintain = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.showStudent)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "课程：";
			// 
			// courseName
			// 
			this.courseName.AutoSize = true;
			this.courseName.Location = new System.Drawing.Point(85, 60);
			this.courseName.Name = "courseName";
			this.courseName.Size = new System.Drawing.Size(65, 12);
			this.courseName.TabIndex = 1;
			this.courseName.Text = "显示课程名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(194, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "任课教师：";
			// 
			// teacherName
			// 
			this.teacherName.AutoSize = true;
			this.teacherName.Location = new System.Drawing.Point(299, 60);
			this.teacherName.Name = "teacherName";
			this.teacherName.Size = new System.Drawing.Size(65, 12);
			this.teacherName.TabIndex = 3;
			this.teacherName.Text = "显示教师名";
			// 
			// select
			// 
			this.select.Location = new System.Drawing.Point(20, 32);
			this.select.Name = "select";
			this.select.Size = new System.Drawing.Size(75, 23);
			this.select.TabIndex = 6;
			this.select.Text = "查询";
			this.select.UseVisualStyleBackColor = true;
			this.select.Click += new System.EventHandler(this.select_Click);
			// 
			// input
			// 
			this.input.Location = new System.Drawing.Point(20, 72);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(75, 23);
			this.input.TabIndex = 7;
			this.input.Text = "输入成绩";
			this.input.UseVisualStyleBackColor = true;
			this.input.Click += new System.EventHandler(this.input_Click);
			// 
			// grade
			// 
			this.grade.Location = new System.Drawing.Point(20, 113);
			this.grade.Name = "grade";
			this.grade.Size = new System.Drawing.Size(75, 23);
			this.grade.TabIndex = 8;
			this.grade.Text = "成绩分布";
			this.grade.UseVisualStyleBackColor = true;
			this.grade.Click += new System.EventHandler(this.grade_Click);
			// 
			// exist
			// 
			this.exist.Location = new System.Drawing.Point(20, 154);
			this.exist.Name = "exist";
			this.exist.Size = new System.Drawing.Size(75, 23);
			this.exist.TabIndex = 9;
			this.exist.Text = "退出";
			this.exist.UseVisualStyleBackColor = true;
			this.exist.Click += new System.EventHandler(this.exist_Click);
			// 
			// courseChoose
			// 
			this.courseChoose.FormattingEnabled = true;
			this.courseChoose.Location = new System.Drawing.Point(6, 34);
			this.courseChoose.Name = "courseChoose";
			this.courseChoose.Size = new System.Drawing.Size(132, 20);
			this.courseChoose.TabIndex = 10;
			this.courseChoose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.courseChoose_MouseClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.courseChoose);
			this.groupBox1.Location = new System.Drawing.Point(12, 107);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(159, 184);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "请选择课程名:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.showStudent);
			this.groupBox2.Location = new System.Drawing.Point(190, 107);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(180, 184);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "已选修此课程的学生:";
			// 
			// showStudent
			// 
			this.showStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.showStudent.Location = new System.Drawing.Point(6, 27);
			this.showStudent.Name = "showStudent";
			this.showStudent.RowTemplate.Height = 23;
			this.showStudent.Size = new System.Drawing.Size(168, 150);
			this.showStudent.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.select);
			this.groupBox3.Controls.Add(this.input);
			this.groupBox3.Controls.Add(this.grade);
			this.groupBox3.Controls.Add(this.exist);
			this.groupBox3.Location = new System.Drawing.Point(386, 107);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(118, 184);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			// 
			// maintainBox
			// 
			this.maintainBox.FormattingEnabled = true;
			this.maintainBox.Location = new System.Drawing.Point(87, 13);
			this.maintainBox.Name = "maintainBox";
			this.maintainBox.Size = new System.Drawing.Size(65, 20);
			this.maintainBox.TabIndex = 14;
			// 
			// maintain
			// 
			this.maintain.Location = new System.Drawing.Point(18, 11);
			this.maintain.Name = "maintain";
			this.maintain.Size = new System.Drawing.Size(56, 23);
			this.maintain.TabIndex = 15;
			this.maintain.Text = "维护";
			this.maintain.UseVisualStyleBackColor = true;
			this.maintain.Click += new System.EventHandler(this.maintain_Click);
			// 
			// CourseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 314);
			this.Controls.Add(this.maintain);
			this.Controls.Add(this.maintainBox);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.teacherName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.courseName);
			this.Controls.Add(this.label1);
			this.Name = "CourseForm";
			this.Text = "成绩管理";
			this.Load += new System.EventHandler(this.CourseForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.showStudent)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label courseName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label teacherName;
		private System.Windows.Forms.Button select;
		private System.Windows.Forms.Button input;
		private System.Windows.Forms.Button grade;
		private System.Windows.Forms.Button exist;
		private System.Windows.Forms.ComboBox courseChoose;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView showStudent;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox maintainBox;
		private System.Windows.Forms.Button maintain;
	}
}