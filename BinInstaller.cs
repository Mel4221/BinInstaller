using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickTools.QIO;
using QuickTools.QData;
using QuickTools.QCore;
using System.Runtime.CompilerServices;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace BinInstaller
{
	public partial class BinInstaller : Form
	{
		public BinInstaller()
		{
			InitializeComponent();
		}
		public string CurrentTextStatus { get; set; } = string.Empty;
		public int CurrentIntStatus { get; set; } = 0;
		private bool IsReporting { get; set; } = false;
		private Action<BackgroundWorker> CurrentAction { get; set; } = null;
		private BinDownloader Bin { get; set; } = new BinDownloader();
		private void Worker_DoWork(object sender, DoWorkEventArgs e)
		{
			if (this.CurrentAction != null)
			{
				this.CurrentAction(this.Worker);
			}
		}

		private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			if (this.ProgressBar.Value < this.ProgressBar.Maximum)
			{
				this.ProgressBar.Value = this.CurrentIntStatus; ;
				this.CurrentStatus.Text = $"{this.CurrentTextStatus}";
			}
		}

		private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			////	MessageBox.Show("Current action completed!!!");

			//if (!_WaitForAckolegeMent)
			//{
			//this.CurrentFileStatus.Visible = false;
			//this.PackFilesProgressBar.Visible = false;
			this.ProgressBar.Value = 0;
			this.CurrentStatus.Text = "";
			this.CurrentAction = null;
			GC.Collect();// because it was holding the files even thought was not needed 
						 //}

			//if (_MessageBoxAllowed || _WaitForAckolegeMent)
			//{
			//	DialogResult result = MessageBox.Show(this.CurrentActionInfo, "Info");
			//	if (result == DialogResult.OK)
			//	{
			//		this._WaitForAckolegeMent = false;
			//		this._MessageBoxAllowed = false;
			//		this.CurrentFileStatus.Visible = false;
			//		this.PackFilesProgressBar.Visible = false;
			//		this.PackFilesProgressBar.Value = 0;
			//		this.CurrentActionInfo = "";
			//	this.CurrentAction = null;
			//	}
			//}

		}
		private void StartReportLoop()
		{
			new Thread(() => {
				while (this.IsReporting)
				{
					this.CurrentTextStatus = this.Bin.CurrentTextStatus;
					this.CurrentIntStatus = this.Bin.CurrentIntStatus;
				}
			}).Start();
		}
		private void DownloadSources()
		{
			this.CurrentAction = (BackgroundWorker worker) =>
			{
				//this.CurrentStatusInt = 50;
				this.Bin.AllowDeubbuger = true;
				this.IsReporting = true;
				//this.CurrentIntStatus++;
				this.StartReportLoop();
				while (this.IsReporting)
				{
					this.CurrentIntStatus++;
					worker.ReportProgress(0);
					Get.WaitTime(1000);
					this.Bin.DownloadSources();
					worker.ReportProgress(0);
					Get.WaitTime(1000);
					this.Bin.Load();
					worker.ReportProgress(0);
					Get.WaitTime(1000);
					this.IsReporting = false;
					return;
				}
				
				//worker.ReportProgress(0);
				//this.Bin.DownloadSources();
				//Get.WaitTime(2000);
				//this.CurrentIntStatus = 100;
				

				//this.Bin.Load();
			};
			this.Worker.RunWorkerAsync();
		}
		private void SetInitialComponents()
		{
			this.BinInstallerCloseBtn.Location = new Point(this.Width-35,3);
			this.WelcomeLabel.Location = new Point((this.Width/2)-80,3);
			this.ProgressBar.Location = new Point(1, this.Height-10);
			this.ProgressBar.Width = this.Width-5;
			this.CurrentStatus.Location = new Point(1, this.Height-30);
			this.DownloadSources();
		}
		private void BinInstaller_Load(object sender, EventArgs e)
		{
			this.SetInitialComponents();
		}

		private void BinInstallerCloseBtn_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BinInstallerCloseBtn_MouseHover(object sender, EventArgs e)
		{
			this.BinInstallerCloseBtn.BackColor = Color.White;
		}

		private void BinInstallerCloseBtn_MouseLeave(object sender, EventArgs e)
		{
			Color col = Color.FromArgb(40, 60, 80);
			this.BinInstallerCloseBtn.BackColor  = col;
		}

		 
		private void SearchPackage_Click(object sender, EventArgs e)
		{

			
				 
			//this.PackageIcon.Image 
		}

		private void PackagesAvailables_Click(object sender, EventArgs e)
		{
			if(this.Bin.Packages.Count > 0 && this.Bin.Packages.Count != this.PackagesAvailables.Items.Count)
			{
				this.Bin.Packages.ForEach(item => this.PackagesAvailables.Items.Add(item.Name));
			}
		}
		private void SetPackageIcon(ref Package package)
		{
			int x, y;
			x = 200;
			y = 200;
			string icon = "";
			foreach(Package.Files file in  package.DependencyFiles)
			{
				if (Get.FileExention(file.Name) == "ico")
				{
					icon = file.Name;
					break;
				}
			}
			if (icon == "") return;
			PictureBox picture = new PictureBox
			{
				Name = "pictureBox",
				Size = new Size(x, y),
				Location = new Point(220, 20),
				ImageLocation =icon,//@"C:\Users\Melquiceded\Documents\csharp\ClownShell\setting.ico",//@"C:\Users\Melquiceded\Documents\csharp\ClownShell\clown.ico",
				SizeMode = PictureBoxSizeMode.StretchImage,
				BorderStyle = BorderStyle.Fixed3D
			};
			this.Controls.Add(picture);
		}
		private void PackagesAvailables_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.PackagesAvailables.Text == "") return;
			this.DependencyDirs.Text = "";
			this.DependencyFiles.Text = "";
		
			try
			{
				
				Package p = this.Bin.GetPackage(this.PackagesAvailables.Text);
				//this.SetPackageIcon(ref p); 
				this.PackageId.Text = p.Id;
				this.PackageSize.Text = p.Size;
				this.PackageCreator.Text = p.Creator;
				this.PackageDescription.Text = p.Description;
				this.PackageDate.Text = p.Date;
				this.PackageSource.Text = p.Source;
				p.DependencyFiles.ForEach(item => this.DependencyFiles.Text+=Get.FileNameFromPath(item.Name)+"\n");
				p.DependencyDirs.ForEach(item => this.DependencyDirs.Text+=Get.FileNameFromPath(item.Name)+"\n");

			}
			catch
			{
				MessageBox.Show("FAILED TO LOAD THE PACKAGE INFOMRATION");
			}
		}

		private void DownloadPackage_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			DialogResult result = folderBrowserDialog.ShowDialog();
			string package = this.PackagesAvailables.Text;
			if (this.PackagesAvailables.Text == "") return;
			if(result == DialogResult.OK)
			{
				if(Directory.Exists(folderBrowserDialog.SelectedPath))
				{
					this.Bin.OutPutPath = folderBrowserDialog.SelectedPath;
					this.Bin.AllowDeubbuger = true;
					this.IsReporting = true;
					this.StartReportLoop();
					this.CurrentAction = (BackgroundWorker worker) =>
					{
						new Thread(() => 
						{ 
							this.Bin.DownloadPackage(package);
							this.IsReporting = false;
						}).Start();
						while(this.IsReporting)
						{
							worker.ReportProgress(0);
							Get.WaitTime(150);
						}
					};
					this.Worker.RunWorkerAsync();
				}
				
			}
		}

		private void PackageSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if(this.PackageSource.Text != "_")
			{
				ProcessStartInfo info = new ProcessStartInfo();
				info.FileName = this.PackageSource.Text;
				Process.Start(info);
			}
			
		}
	}
}
