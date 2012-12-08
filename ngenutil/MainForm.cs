using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ngenutil
{
	partial class MainForm : Form
	{
		//private bool closeAfterProcess;

		private bool _Processing;

		public bool Processing
		{
			set
			{
				btnInstall.Enabled = !value;
				btnUninstall.Enabled = !value;
				btnUpdate.Enabled = !value;
				//btnCancel.Enabled = value;
				btnCancel.Visible = value;
				//progressBar.Enabled = value;
				progressBar.Visible = value;
				//txtStatus.Enabled = value;
				//txtStatus.Enabled = value;
				txtPath.Enabled = !value;
				_Processing = value;
			}
			get
			{
				return _Processing;
			}
		}

		Ngen ngen;

		public MainForm()
		{
			Initialize();
		}

		public MainForm(NgenType type, string path)
		{
			Initialize();
			//closeAfterProcess = true;
			txtPath.Text = path;
			Shown += (obj, e) => StartNgen(type);
		}

		private void Initialize()
		{
			InitializeComponent();
			this.Text = Resource.ApplicationName + " - " + Resource.Author;
			Processing = false;
			ChangedPath();
			FormClosing += (obj, e) =>
			{
				if (ngen != null)
					ngen.Dispose();
			};

		}

		static bool CheckPath(string path)
		{
			return
				File.Exists(path) &&
				Path.GetExtension(path) == Resource.ExecutableExtension;
		}

		private void StartNgen(NgenType type)
		{
			if (Processing == false && (type == NgenType.Update || CheckPath(txtPath.Text)))
			{
				Processing = true;
				ngen = new Ngen(this, type, txtPath.Text);
				ngen.Exited += ngen_Exited;
				ngen.ProgressChanged += ngen_ProgressChanged;
				ngen.Start();
			}
			else
			{
				MessageBox.Show(Resource.PathMissing);
			}
		}

		private void btnRefer_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = Resource.ReferFilter;
			if (ofd.ShowDialog() == DialogResult.OK)
				txtPath.Text = ofd.FileName;
			ofd.Dispose();
		}

		private void txtPath_TextChanged(object sender, EventArgs e)
		{
			ChangedPath();
		}

		private void ChangedPath()
		{
			btnInstall.Enabled = btnUninstall.Enabled = CheckPath(txtPath.Text);
		}

		private void btnInstall_Click(object sender, EventArgs e)
		{
			StartNgen(NgenType.Install);
		}

		void ngen_ProgressChanged(object value, NgenProgressEventArgs e)
		{
			txtStatus.AppendText(e.Data + "\r\n");
		}

		void ngen_Exited(object sender, EventArgs e)
		{
			txtStatus.AppendText("Exited \"ngen\".\r\n\r\n");
			Processing = false;
		}

		private void btnUninstall_Click(object sender, EventArgs e)
		{
			StartNgen(NgenType.Uninstall);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (ngen != null)
				ngen.Kill();
			Processing = false;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			StartNgen(NgenType.Update);
		}

		//private void MainForm_DragEnter(object sender, DragEventArgs e)
		//{
			
		//	string[] fileNameArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
		//	string textArray = (string)e.Data.GetData(DataFormats.Text, false);
		//	if (e.Data.GetDataPresent(DataFormats.Text) ||
		//		e.Data.GetDataPresent(DataFormats.UnicodeText))
		//	{
		//		e.Effect = DragDropEffects.Copy;
		//	}
		//	else if (e.Data.GetDataPresent(DataFormats.FileDrop))
		//	{
		//		// file
		//		string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
		//		if (Path.GetExtension(files[0]) == Resource.ExecutableExtension)
		//			e.Effect = DragDropEffects.Copy;
		//		else
		//			e.Effect = DragDropEffects.None;
		//	}
		//	else
		//		e.Effect = DragDropEffects.None;
		//}

		//private void MainForm_DragDrop(object sender, DragEventArgs e)
		//{
		//	string text = OnDragDrop(e);
		//	if (string.IsNullOrEmpty(text) == false && string.IsNullOrWhiteSpace(text) == false)
		//		txtPath.Text = text;
		//}

		//static string OnDragDrop(DragEventArgs e)
		//{
		//	if (e.Data.GetDataPresent(DataFormats.Text))
		//	{
		//		return (string)e.Data.GetData(DataFormats.Text);
		//	}
		//	else if (e.Data.GetDataPresent(DataFormats.UnicodeText))
		//	{
		//		return (string)e.Data.GetData(DataFormats.UnicodeText);
		//	}
		//	else if (e.Data.GetDataPresent(DataFormats.FileDrop))
		//	{
		//		string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
		//		if (Path.GetExtension(files[0]) == Resource.ExecutableExtension)
		//			return files[0];
		//		else
		//			return null;
		//	}
		//	else
		//		return null;
		//}

		//private void btnInstall_DragDrop(object sender, DragEventArgs e)
		//{
		//	string text = OnDragDrop(e);
		//	if (string.IsNullOrEmpty(text) == false && string.IsNullOrWhiteSpace(text) == false)
		//	{
		//		txtPath.Text = text;
		//		StartNgen(NgenType.Install);
		//	}
		//}

		//private void btnUninstall_DragDrop(object sender, DragEventArgs e)
		//{
		//	string text = OnDragDrop(e);
		//	if (string.IsNullOrEmpty(text) == false && string.IsNullOrWhiteSpace(text) == false)
		//	{
		//		txtPath.Text = text;
		//		StartNgen(NgenType.Uninstall);
		//	}
		//}

	}
}
