namespace ngenutil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblPath = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnRefer = new System.Windows.Forms.Button();
			this.btnInstall = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUninstall = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPath
			// 
			this.lblPath.AllowDrop = true;
			resources.ApplyResources(this.lblPath, "lblPath");
			this.lblPath.Name = "lblPath";
			// 
			// txtPath
			// 
			this.txtPath.AllowDrop = true;
			resources.ApplyResources(this.txtPath, "txtPath");
			this.txtPath.Name = "txtPath";
			this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// btnRefer
			// 
			this.btnRefer.AllowDrop = true;
			resources.ApplyResources(this.btnRefer, "btnRefer");
			this.btnRefer.Name = "btnRefer";
			this.btnRefer.UseVisualStyleBackColor = true;
			this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
			// 
			// btnInstall
			// 
			this.btnInstall.AllowDrop = true;
			resources.ApplyResources(this.btnInstall, "btnInstall");
			this.btnInstall.Name = "btnInstall";
			this.btnInstall.UseVisualStyleBackColor = true;
			this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
			// 
			// progressBar
			// 
			resources.ApplyResources(this.progressBar, "progressBar");
			this.progressBar.Name = "progressBar";
			this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			// 
			// txtStatus
			// 
			this.txtStatus.AllowDrop = true;
			resources.ApplyResources(this.txtStatus, "txtStatus");
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			// 
			// btnCancel
			// 
			resources.ApplyResources(this.btnCancel, "btnCancel");
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnUninstall
			// 
			this.btnUninstall.AllowDrop = true;
			resources.ApplyResources(this.btnUninstall, "btnUninstall");
			this.btnUninstall.Name = "btnUninstall";
			this.btnUninstall.UseVisualStyleBackColor = true;
			this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.AllowDrop = true;
			resources.ApplyResources(this.btnUpdate, "btnUpdate");
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnInstall;
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnUninstall);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.btnInstall);
			this.Controls.Add(this.btnRefer);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.lblPath);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnRefer;
		private System.Windows.Forms.Button btnInstall;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.TextBox txtStatus;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUninstall;
		private System.Windows.Forms.Button btnUpdate;
	}
}

