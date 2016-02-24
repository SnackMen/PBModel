namespace PBModel
{
	partial class LoginForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			userName = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.login = new System.Windows.Forms.Button();
			this.exist = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "口  令：";
			// 
			// userName
			// 
			userName.Location = new System.Drawing.Point(108, 33);
			userName.Name = "userName";
			userName.Size = new System.Drawing.Size(150, 21);
			userName.TabIndex = 2;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(108, 87);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(150, 21);
			this.password.TabIndex = 3;
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(46, 165);
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(75, 23);
			this.login.TabIndex = 4;
			this.login.Text = "登录";
			this.login.UseVisualStyleBackColor = true;
			this.login.Click += new System.EventHandler(this.login_Click);
			// 
			// exist
			// 
			this.exist.Location = new System.Drawing.Point(203, 165);
			this.exist.Name = "exist";
			this.exist.Size = new System.Drawing.Size(75, 23);
			this.exist.TabIndex = 5;
			this.exist.Text = "退出";
			this.exist.UseVisualStyleBackColor = true;
			this.exist.Click += new System.EventHandler(this.exist_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 220);
			this.Controls.Add(this.exist);
			this.Controls.Add(this.login);
			this.Controls.Add(this.password);
			this.Controls.Add(userName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.Text = "系统登录";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public static System.Windows.Forms.TextBox userName;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Button login;
		private System.Windows.Forms.Button exist;
	}
}

