using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Forms;

namespace ngenutil
{
	delegate void NgenProgressEventHandler(object value, NgenProgressEventArgs e);

	enum NgenType
	{
		Install,
		Uninstall,
		Update,
	}

	enum NgenState
	{
		Ready,
		Processing,
		Finished,
	}

	class Ngen : IDisposable
	{
		public NgenType Type { private set; get; }
		public string FileName { private set; get; }
		public NgenState State { protected set; get; }
		public int? ExitCode { private set; get; }

		private Form form;
		private Process process;

		public event NgenProgressEventHandler ProgressChanged;
		public event EventHandler Exited;

		public Ngen(Form form, NgenType type, string path)
		{
			this.form = form;
			this.Type = type;
			this.FileName = path;
			this.State = NgenState.Ready;

		}

		public void Start()
		{

			string runtimePath = RuntimeEnvironment.GetRuntimeDirectory();
			string ngenPath = Path.Combine(runtimePath, "ngen.exe");

			string command;
			switch (Type)
			{
				case NgenType.Install:
					command = "install";
					command += " /nologo";
					command += " \"" + FileName + "\"";
					break;
				case NgenType.Uninstall:
					command = "uninstall";
					command += " /nologo";
					command += " \"" + FileName + "\"";
					break;
				case NgenType.Update:
					command = "update";
					command += " /nologo";
					break;
				default:
					throw new NotImplementedException();
			}
			//command += " /nologo";
			//command += " \"" + FileName + "\"";

			ProcessStartInfo startInfo = new ProcessStartInfo(ngenPath, command);
			startInfo.CreateNoWindow = true;
			startInfo.UseShellExecute = false;
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			//startInfo.StandardOutputEncoding = Encoding.UTF8;

			try
			{
				process = new Process();
				process.StartInfo = startInfo;
				process.EnableRaisingEvents = true;

				process.OutputDataReceived += process_OutputDataReceived;
				process.Exited += process_Exited;
				// write console
				OnProgressChanged(new NgenProgressEventArgs("Starting \"ngen\"..."));
				OnProgressChanged(new NgenProgressEventArgs("File name : " + startInfo.FileName));
				OnProgressChanged(new NgenProgressEventArgs("Command : " + startInfo.Arguments + "\r\n"));

				process.Start();
				process.BeginErrorReadLine();
				process.BeginOutputReadLine();
			}
			catch (Exception ex)
			{
				string message = ex.Message;
				if (ex.InnerException != null)
					message += "\r\n\r\n" + ex.InnerException.Message;

				MessageBox.Show(message, Resource.ApplicationName);
			}
		}

		public void Kill()
		{
			if (process != null)
				process.Kill();
		}

		public void Dispose()
		{
			if (process != null)
				process.Dispose();
		}

		public void OnProgressChanged(NgenProgressEventArgs e)
		{
			if (ProgressChanged != null)
			{
				form.Invoke(ProgressChanged, this, e);
				//ProgressChanged(this, e);
			}
		}

		public void OnExited(EventArgs e)
		{
			ExitCode = process.ExitCode;
			if (Exited != null)
			{
				form.Invoke(Exited, this, e);
				//Exited(this, e);
			}
		}

		void process_Exited(object sender, EventArgs e)
		{
			OnExited(e);
		}

		void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			OnProgressChanged(new NgenProgressEventArgs(e.Data));
		}

	}

	class NgenProgressEventArgs : EventArgs
	{
		public string Data { private set; get; }

		public NgenProgressEventArgs(string data)
		{
			this.Data = data;
		}
	}

}
