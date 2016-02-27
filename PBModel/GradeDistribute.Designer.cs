namespace PBModel
{
	partial class GradeDistribute
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.grade = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.grade)).BeginInit();
			this.SuspendLayout();
			// 
			// grade
			// 
			chartArea1.Name = "ChartArea1";
			this.grade.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.grade.Legends.Add(legend1);
			this.grade.Location = new System.Drawing.Point(1, -2);
			this.grade.Name = "grade";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.grade.Series.Add(series1);
			this.grade.Size = new System.Drawing.Size(438, 270);
			this.grade.TabIndex = 0;
			this.grade.Text = "grade";
			// 
			// GradeDistribute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 262);
			this.Controls.Add(this.grade);
			this.Name = "GradeDistribute";
			this.Text = "成绩分布情况";
			this.Load += new System.EventHandler(this.GradeDistribute_Load);
			((System.ComponentModel.ISupportInitialize)(this.grade)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart grade;


	}
}