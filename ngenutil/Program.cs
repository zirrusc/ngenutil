using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngenutil
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static int Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args.Length == 0)
			{
				Application.Run(new MainForm());
			}
			else
			{
				NgenType type;
				string path;
	
	
				string action = args[0].ToLower();
				switch (action)
				{
					case "update":
						type = NgenType.Update;
						break;
					case "install":
						type = NgenType.Install;
						break;
					case "uninstall":
						type = NgenType.Uninstall;
						break;
					case "--help":
					case "-h":
					case "help":
						Help(true);
						return 0;
					default:
						Help(true, "Invalid option");
						return -1;
				}

				if (type != NgenType.Update && args.Length == 1)
				{
					Help(true, "Assembly name is required.");
					return -2;
				}
				else
				{
					path = args[1];
				}

				Application.Run(new MainForm(type, path));
			}
			return 0;
		}

		static void Help(bool console, string appendText)
		{
			if (console)
			{
				Console.WriteLine(Resource.ApplicationName);
				Console.WriteLine(Resource.Author);
				Console.WriteLine();
				Console.WriteLine(appendText);
				Console.WriteLine(Resource.ParameterText);
			}
			else
			{
				MessageBox.Show(appendText + "\r\n\r\n" + Resource.ParameterText,
					Resource.ApplicationName + " - Author : " + Resource.Author);
			}
		}

		static void Help(bool console)
		{
			if (console)
			{
				Console.WriteLine(Resource.ApplicationName);
				Console.WriteLine(Resource.Author);
				Console.WriteLine();
				Console.WriteLine(Resource.ParameterText);
			}
			else
			{
				MessageBox.Show(Resource.ParameterText, 
					Resource.ApplicationName + " - Author : " + Resource.Author);
			}

		}
	}
}
