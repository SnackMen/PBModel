namespace PBModel
{
	partial class StudentGradeForm
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
			this.studentGrade = new System.Windows.Forms.DataGridView();
			this.number = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.studentGrade)).BeginInit();
			this.SuspendLayout();
			// 
			// studentGrade
			// 
			this.studentGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentGrade.Location = new System.Drawing.Point(12, 44);
			this.studentGrade.Name = "studentGrade";
			this.studentGrade.RowTemplate.Height = 23;
			this.studentGrade.Size = new System.Drawing.Size(470, 241);
			this.studentGrade.TabIndex = 0;
			this.studentGrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// number
			// 
			this.number.AutoSize = true;
			this.number.Location = new System.Drawing.Point(110, 18);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(29, 12);
			this.number.TabIndex = 1;
			this.number.Text = "学号";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(196, 18);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(29, 12);
			this.name.TabIndex = 2;
			this.name.Text = "姓名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(264, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "的生成成绩单";
			// 
			// StudentGradeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 309);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.name);
			this.Controls.Add(this.number);
			this.Controls.Add(this.studentGrade);
			this.Name = "StudentGradeForm";
			this.Text = "学生成绩单";
			this.Load += new System.EventHandler(this.StudentGradeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.studentGrade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView studentGrade;
		private System.Windows.Forms.Label number;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label label3;
	}
}