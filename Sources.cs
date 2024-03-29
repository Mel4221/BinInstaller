using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using QuickTools.QNet;
using System.Net;
using System.IO;

namespace BinInstaller
{
	public partial class Sources : Form
	{
		public Sources()
		{
			InitializeComponent();
		}
		private const string LicenceLink = "https://raw.githubusercontent.com/Mel4221/QuickTools/testing/LICENSE";
		private const string LicenceFile = "LICENCE.TXT";
		private const string QuickToolsLink = "https://github.com/Mel4221/QuickTools/raw/testing/bin/Release/QuickTools.dll";
		private void DownloadLicence()
		{
			try
			{
				DownloadFile(LicenceLink, LicenceFile );
			}catch{
				String info = $"FAILED TO DOWNLOAD THE UPDATED LICENCE";
				MessageBox.Show(info);
				this.LicenceView.Text = $"{info}\nTO VIEW THE LICENCE PLEASE VISIT: {LicenceLink}";

				return;
			}
			GC.Collect();
			this.LicenceView.Text = File.ReadAllText(LicenceFile);
		}
		private static string Status(object current, object goal)
		{
			string status = null;
			double c = Convert.ToDouble(current);
			double g = Convert.ToDouble(goal);
			double s = Math.Round(c / g, 2) * 100;
			status = $"{s}%";
			return status;

		}
		public static void DownloadFile(string address, string fileName)
		{

			using (WebClient client = new WebClient())
			{
				client.UseDefaultCredentials = true;

				Uri Uri = new Uri(address);
				//_completed = false;

				//client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
				//client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgress);
				client.DownloadFileAsync(Uri, fileName);
				while (client.IsBusy)
				{
					Console.WriteLine($"DOWNLOADING: [{address}]");
				}
			}

		}
		private void Sources_Load(object sender, EventArgs e)
		{
			this.DownloadLicence();
		}

		private void LicenceLInkBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ProcessStartInfo info = new ProcessStartInfo();
			info.FileName = LicenceLink;
			Process.Start(info); 

		}

		private void LincenceAckBtn_CheckedChanged(object sender, EventArgs e)
		{
			if(this.DownloadQuickTools.Visible)
			{
				this.DownloadQuickTools.Visible = false;
				return;
			}else{
				this.DownloadQuickTools.Visible = true;
			}
		}

		private void DownloadQuickTools_Click(object sender, EventArgs e)
		{
			try
			{
				DownloadFile(QuickToolsLink, "QuickTools.dll");
				GC.Collect();
				this.Hide();
				BinInstaller bin = new BinInstaller();
				bin.Show(); 
			}catch{
				MessageBox.Show($"FAILED TO DOWNLOAD THE PACKAGE QuickTools.dll WHICH IS REQUIRED TO CONTINUE");
				return;
			}
			this.Hide();
		}
	}
}
