namespace BinInstaller
{
	partial class BinInstaller
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinInstaller));
			this.WelcomeLabel = new System.Windows.Forms.Label();
			this.BinInstallerCloseBtn = new System.Windows.Forms.PictureBox();
			this.PackagesAvailables = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchPackage = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.DependencyFiles = new System.Windows.Forms.RichTextBox();
			this.PackageDependencryFiles = new System.Windows.Forms.Label();
			this.PackageDependencyDirs = new System.Windows.Forms.Label();
			this.DependencyDirs = new System.Windows.Forms.RichTextBox();
			this.PackageId = new System.Windows.Forms.Label();
			this.PackageSize = new System.Windows.Forms.Label();
			this.PackageCreator = new System.Windows.Forms.Label();
			this.PackageDescription = new System.Windows.Forms.Label();
			this.PackageDate = new System.Windows.Forms.Label();
			this.PackageSource = new System.Windows.Forms.Label();
			this.ProgressBar = new System.Windows.Forms.ProgressBar();
			this.CurrentStatus = new System.Windows.Forms.Label();
			this.DownloadPackage = new System.Windows.Forms.Button();
			this.Worker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.BinInstallerCloseBtn)).BeginInit();
			this.SuspendLayout();
			// 
			// WelcomeLabel
			// 
			this.WelcomeLabel.AutoSize = true;
			this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
			this.WelcomeLabel.Location = new System.Drawing.Point(29, 34);
			this.WelcomeLabel.Name = "WelcomeLabel";
			this.WelcomeLabel.Size = new System.Drawing.Size(351, 37);
			this.WelcomeLabel.TabIndex = 0;
			this.WelcomeLabel.Text = "Welcome to Bininstaller";
			// 
			// BinInstallerCloseBtn
			// 
			this.BinInstallerCloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("BinInstallerCloseBtn.Image")));
			this.BinInstallerCloseBtn.Location = new System.Drawing.Point(1380, 12);
			this.BinInstallerCloseBtn.Name = "BinInstallerCloseBtn";
			this.BinInstallerCloseBtn.Size = new System.Drawing.Size(43, 49);
			this.BinInstallerCloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BinInstallerCloseBtn.TabIndex = 1;
			this.BinInstallerCloseBtn.TabStop = false;
			this.BinInstallerCloseBtn.Click += new System.EventHandler(this.BinInstallerCloseBtn_Click);
			this.BinInstallerCloseBtn.MouseLeave += new System.EventHandler(this.BinInstallerCloseBtn_MouseLeave);
			this.BinInstallerCloseBtn.MouseHover += new System.EventHandler(this.BinInstallerCloseBtn_MouseHover);
			// 
			// PackagesAvailables
			// 
			this.PackagesAvailables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackagesAvailables.FormattingEnabled = true;
			this.PackagesAvailables.Location = new System.Drawing.Point(214, 380);
			this.PackagesAvailables.Name = "PackagesAvailables";
			this.PackagesAvailables.Size = new System.Drawing.Size(519, 37);
			this.PackagesAvailables.TabIndex = 2;
			this.PackagesAvailables.SelectedIndexChanged += new System.EventHandler(this.PackagesAvailables_SelectedIndexChanged);
			this.PackagesAvailables.Click += new System.EventHandler(this.PackagesAvailables_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 374);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 37);
			this.label1.TabIndex = 3;
			this.label1.Text = "Package";
			// 
			// SearchPackage
			// 
			this.SearchPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SearchPackage.Location = new System.Drawing.Point(754, 377);
			this.SearchPackage.Name = "SearchPackage";
			this.SearchPackage.Size = new System.Drawing.Size(111, 41);
			this.SearchPackage.TabIndex = 4;
			this.SearchPackage.Text = "Search";
			this.SearchPackage.UseVisualStyleBackColor = true;
			this.SearchPackage.Click += new System.EventHandler(this.SearchPackage_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(49, 473);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 37);
			this.label2.TabIndex = 5;
			this.label2.Text = "Size";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(49, 529);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 37);
			this.label3.TabIndex = 7;
			this.label3.Text = "Creator";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(49, 585);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(177, 37);
			this.label4.TabIndex = 9;
			this.label4.Text = "Description";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(49, 423);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 37);
			this.label5.TabIndex = 10;
			this.label5.Text = "Id";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(49, 642);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(84, 37);
			this.label6.TabIndex = 11;
			this.label6.Text = "Date";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(49, 700);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 37);
			this.label7.TabIndex = 12;
			this.label7.Text = "Source";
			// 
			// DependencyFiles
			// 
			this.DependencyFiles.Location = new System.Drawing.Point(56, 812);
			this.DependencyFiles.Name = "DependencyFiles";
			this.DependencyFiles.Size = new System.Drawing.Size(290, 233);
			this.DependencyFiles.TabIndex = 13;
			this.DependencyFiles.Text = "";
			// 
			// PackageDependencryFiles
			// 
			this.PackageDependencryFiles.AutoSize = true;
			this.PackageDependencryFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageDependencryFiles.ForeColor = System.Drawing.Color.White;
			this.PackageDependencryFiles.Location = new System.Drawing.Point(49, 761);
			this.PackageDependencryFiles.Name = "PackageDependencryFiles";
			this.PackageDependencryFiles.Size = new System.Drawing.Size(306, 37);
			this.PackageDependencryFiles.TabIndex = 14;
			this.PackageDependencryFiles.Text = "Dependency     Files";
			// 
			// PackageDependencyDirs
			// 
			this.PackageDependencyDirs.AutoSize = true;
			this.PackageDependencyDirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageDependencyDirs.ForeColor = System.Drawing.Color.White;
			this.PackageDependencyDirs.Location = new System.Drawing.Point(387, 761);
			this.PackageDependencyDirs.Name = "PackageDependencyDirs";
			this.PackageDependencyDirs.Size = new System.Drawing.Size(346, 37);
			this.PackageDependencyDirs.TabIndex = 15;
			this.PackageDependencyDirs.Text = "Dependency Directorys";
			// 
			// DependencyDirs
			// 
			this.DependencyDirs.Location = new System.Drawing.Point(394, 812);
			this.DependencyDirs.Name = "DependencyDirs";
			this.DependencyDirs.Size = new System.Drawing.Size(339, 233);
			this.DependencyDirs.TabIndex = 16;
			this.DependencyDirs.Text = "";
			// 
			// PackageId
			// 
			this.PackageId.AutoSize = true;
			this.PackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageId.ForeColor = System.Drawing.Color.White;
			this.PackageId.Location = new System.Drawing.Point(448, 423);
			this.PackageId.Name = "PackageId";
			this.PackageId.Size = new System.Drawing.Size(35, 37);
			this.PackageId.TabIndex = 17;
			this.PackageId.Text = "_";
			// 
			// PackageSize
			// 
			this.PackageSize.AutoSize = true;
			this.PackageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageSize.ForeColor = System.Drawing.Color.White;
			this.PackageSize.Location = new System.Drawing.Point(413, 473);
			this.PackageSize.Name = "PackageSize";
			this.PackageSize.Size = new System.Drawing.Size(35, 37);
			this.PackageSize.TabIndex = 18;
			this.PackageSize.Text = "_";
			// 
			// PackageCreator
			// 
			this.PackageCreator.AutoSize = true;
			this.PackageCreator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageCreator.ForeColor = System.Drawing.Color.White;
			this.PackageCreator.Location = new System.Drawing.Point(367, 529);
			this.PackageCreator.Name = "PackageCreator";
			this.PackageCreator.Size = new System.Drawing.Size(35, 37);
			this.PackageCreator.TabIndex = 19;
			this.PackageCreator.Text = "_";
			// 
			// PackageDescription
			// 
			this.PackageDescription.AutoSize = true;
			this.PackageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageDescription.ForeColor = System.Drawing.Color.White;
			this.PackageDescription.Location = new System.Drawing.Point(367, 585);
			this.PackageDescription.Name = "PackageDescription";
			this.PackageDescription.Size = new System.Drawing.Size(20, 22);
			this.PackageDescription.TabIndex = 20;
			this.PackageDescription.Text = "_";
			// 
			// PackageDate
			// 
			this.PackageDate.AutoSize = true;
			this.PackageDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageDate.ForeColor = System.Drawing.Color.White;
			this.PackageDate.Location = new System.Drawing.Point(407, 642);
			this.PackageDate.Name = "PackageDate";
			this.PackageDate.Size = new System.Drawing.Size(35, 37);
			this.PackageDate.TabIndex = 21;
			this.PackageDate.Text = "_";
			// 
			// PackageSource
			// 
			this.PackageSource.AutoSize = true;
			this.PackageSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PackageSource.ForeColor = System.Drawing.Color.White;
			this.PackageSource.Location = new System.Drawing.Point(373, 700);
			this.PackageSource.Name = "PackageSource";
			this.PackageSource.Size = new System.Drawing.Size(35, 37);
			this.PackageSource.TabIndex = 22;
			this.PackageSource.Text = "_";
			// 
			// ProgressBar
			// 
			this.ProgressBar.Location = new System.Drawing.Point(-11, 974);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new System.Drawing.Size(1447, 23);
			this.ProgressBar.TabIndex = 23;
			// 
			// CurrentStatus
			// 
			this.CurrentStatus.AutoSize = true;
			this.CurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentStatus.ForeColor = System.Drawing.Color.White;
			this.CurrentStatus.Location = new System.Drawing.Point(777, 909);
			this.CurrentStatus.Name = "CurrentStatus";
			this.CurrentStatus.Size = new System.Drawing.Size(44, 26);
			this.CurrentStatus.TabIndex = 24;
			this.CurrentStatus.Text = "0%";
			this.CurrentStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DownloadPackage
			// 
			this.DownloadPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DownloadPackage.Location = new System.Drawing.Point(883, 377);
			this.DownloadPackage.Name = "DownloadPackage";
			this.DownloadPackage.Size = new System.Drawing.Size(138, 41);
			this.DownloadPackage.TabIndex = 26;
			this.DownloadPackage.Text = "Download";
			this.DownloadPackage.UseVisualStyleBackColor = true;
			this.DownloadPackage.Click += new System.EventHandler(this.DownloadPackage_Click);
			// 
			// Worker
			// 
			this.Worker.WorkerReportsProgress = true;
			this.Worker.WorkerSupportsCancellation = true;
			this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
			this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Worker_ProgressChanged);
			this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Worker_RunWorkerCompleted);
			// 
			// BinInstaller
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(1461, 1097);
			this.Controls.Add(this.DownloadPackage);
			this.Controls.Add(this.CurrentStatus);
			this.Controls.Add(this.ProgressBar);
			this.Controls.Add(this.PackageSource);
			this.Controls.Add(this.PackageDate);
			this.Controls.Add(this.PackageDescription);
			this.Controls.Add(this.PackageCreator);
			this.Controls.Add(this.PackageSize);
			this.Controls.Add(this.PackageId);
			this.Controls.Add(this.DependencyDirs);
			this.Controls.Add(this.PackageDependencyDirs);
			this.Controls.Add(this.PackageDependencryFiles);
			this.Controls.Add(this.DependencyFiles);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SearchPackage);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PackagesAvailables);
			this.Controls.Add(this.BinInstallerCloseBtn);
			this.Controls.Add(this.WelcomeLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BinInstaller";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bininstaller";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.BinInstaller_Load);
			((System.ComponentModel.ISupportInitialize)(this.BinInstallerCloseBtn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label WelcomeLabel;
		private System.Windows.Forms.PictureBox BinInstallerCloseBtn;
		private System.Windows.Forms.ComboBox PackagesAvailables;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SearchPackage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox DependencyFiles;
		private System.Windows.Forms.Label PackageDependencryFiles;
		private System.Windows.Forms.Label PackageDependencyDirs;
		private System.Windows.Forms.RichTextBox DependencyDirs;
		private System.Windows.Forms.Label PackageId;
		private System.Windows.Forms.Label PackageSize;
		private System.Windows.Forms.Label PackageCreator;
		private System.Windows.Forms.Label PackageDescription;
		private System.Windows.Forms.Label PackageDate;
		private System.Windows.Forms.Label PackageSource;
		private System.Windows.Forms.ProgressBar ProgressBar;
		private System.Windows.Forms.Label CurrentStatus;
		private System.Windows.Forms.Button DownloadPackage;
		private System.ComponentModel.BackgroundWorker Worker;
	}
}