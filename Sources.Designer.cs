namespace BinInstaller
{
	partial class Sources
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
			this.LincenceAckBtn = new System.Windows.Forms.CheckBox();
			this.LicenceView = new System.Windows.Forms.RichTextBox();
			this.LicenceLInkBtn = new System.Windows.Forms.LinkLabel();
			this.DownloadQuickTools = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LincenceAckBtn
			// 
			this.LincenceAckBtn.AutoSize = true;
			this.LincenceAckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LincenceAckBtn.ForeColor = System.Drawing.Color.White;
			this.LincenceAckBtn.Location = new System.Drawing.Point(12, 389);
			this.LincenceAckBtn.Name = "LincenceAckBtn";
			this.LincenceAckBtn.Size = new System.Drawing.Size(233, 36);
			this.LincenceAckBtn.TabIndex = 0;
			this.LincenceAckBtn.Text = "Accept Licence";
			this.LincenceAckBtn.UseVisualStyleBackColor = true;
			this.LincenceAckBtn.CheckedChanged += new System.EventHandler(this.LincenceAckBtn_CheckedChanged);
			// 
			// LicenceView
			// 
			this.LicenceView.Location = new System.Drawing.Point(12, 22);
			this.LicenceView.Name = "LicenceView";
			this.LicenceView.ReadOnly = true;
			this.LicenceView.Size = new System.Drawing.Size(769, 349);
			this.LicenceView.TabIndex = 1;
			this.LicenceView.Text = "";
			// 
			// LicenceLInkBtn
			// 
			this.LicenceLInkBtn.AutoSize = true;
			this.LicenceLInkBtn.Location = new System.Drawing.Point(301, 400);
			this.LicenceLInkBtn.Name = "LicenceLInkBtn";
			this.LicenceLInkBtn.Size = new System.Drawing.Size(165, 20);
			this.LicenceLInkBtn.TabIndex = 2;
			this.LicenceLInkBtn.TabStop = true;
			this.LicenceLInkBtn.Text = "Visit QuickTools licnce";
			this.LicenceLInkBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LicenceLInkBtn_LinkClicked);
			// 
			// DownloadQuickTools
			// 
			this.DownloadQuickTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownloadQuickTools.Location = new System.Drawing.Point(631, 389);
			this.DownloadQuickTools.Name = "DownloadQuickTools";
			this.DownloadQuickTools.Size = new System.Drawing.Size(150, 49);
			this.DownloadQuickTools.TabIndex = 27;
			this.DownloadQuickTools.Text = "Download";
			this.DownloadQuickTools.UseVisualStyleBackColor = true;
			this.DownloadQuickTools.Visible = false;
			this.DownloadQuickTools.Click += new System.EventHandler(this.DownloadQuickTools_Click);
			// 
			// Sources
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DownloadQuickTools);
			this.Controls.Add(this.LicenceLInkBtn);
			this.Controls.Add(this.LicenceView);
			this.Controls.Add(this.LincenceAckBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Sources";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BinInstaller Sources";
			this.Load += new System.EventHandler(this.Sources_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox LincenceAckBtn;
		private System.Windows.Forms.RichTextBox LicenceView;
		private System.Windows.Forms.LinkLabel LicenceLInkBtn;
		private System.Windows.Forms.Button DownloadQuickTools;
	}
}