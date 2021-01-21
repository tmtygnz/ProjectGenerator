using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ProjectGenerator
{
	public partial class MainWindow : Form
	{
		string folderPath = @"";
		String genFilePath = "./Generator Files/gen.json";
		public MainWindow()
		{
			InitializeComponent();
		}
		public void loadFile()
		{
			StreamReader reader = new StreamReader(genFilePath);
			String genFileString = reader.ReadToEnd();
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(genFileString);
			for (int i = 0; i != obj["language"].Count; i++)
			{
				LangSlect.Items.Add(obj["language"][i]["Name"]);
			}
			reader.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadFile();
			LangSlect.SelectedIndex = 0;
		}

		private void LangSlect_SelectedIndexChanged(object sender, EventArgs e)
		{
			StreamReader reader = new StreamReader(genFilePath);
			String genFileString = reader.ReadToEnd();
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(genFileString);
			int selected = LangSlect.SelectedIndex;
			if(obj["language"][selected]["OpenCmd"] == true)
			{
				CMDBool.Checked = true;
			}
			if (obj["language"][selected]["OpenCmd"] != true)
			{
				CMDBool.Checked = false;
			}
			if(obj["language"][selected]["openInExplorer"] == true)
			{
				OpenExp.Checked = true;
			}
			if (obj["language"][selected]["openInExplorer"] != true)
			{
				OpenExp.Checked = false;
			}
			reader.Close();
		}


		private void graph_Click(object sender, EventArgs e)
		{
			if(folderPath == "")
			{
				FolderBrowserDialog open = new FolderBrowserDialog();
				if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					folderPath = open.SelectedPath;
					path.Text = folderPath;
					this.Text = folderPath;
				}
				addFolders();
				addFiles();
				if (CMDBool.Checked == true)
				{
					Process process = new Process();
					process.StartInfo.FileName = "cmd.exe";
					process.StartInfo.WorkingDirectory = folderPath;
					process.Start();
				}
				if(OpenExp.Checked == true)
				{
					Process.Start(folderPath);
				}
			}
			else
			{
				addFolders();
				addFiles();
				if (CMDBool.Checked == true)
				{
					Process process = new Process();
					process.StartInfo.FileName = "cmd.exe";
					process.StartInfo.WorkingDirectory = folderPath;
					process.Start();
				}
				if (OpenExp.Checked == true)
				{
					Process.Start(folderPath);
				}
			}
		}


		private void path_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog open = new FolderBrowserDialog();
			if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				folderPath = open.SelectedPath;
				path.Text = folderPath;
				this.Text = folderPath;
			}
		}
		public void addFolders()
		{
			StreamReader reader = new StreamReader(genFilePath);
			String genFileString = reader.ReadToEnd();
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(genFileString);
			int selected = LangSlect.SelectedIndex;
			for(int i = 0; i != obj["language"][selected]["Folders"].Count; i++)
			{
				Directory.CreateDirectory(folderPath + "/" + obj["language"][selected]["Folders"][i]["dir"]);
				this.Text = folderPath + "/" + obj["language"][selected]["Folders"][i]["dir"];
			}
			reader.Close();
		}

		private void editGeneratorPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You can add, edit, delete templates in the gen.json file", "What you can do");
			Process.Start(Application.StartupPath + "\\Generator Files");
		}
		public void addFiles()
		{
			StreamReader reader = new StreamReader(genFilePath);
			String genFileString = reader.ReadToEnd();
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(genFileString);
			int selected = LangSlect.SelectedIndex;
			for(int i = 0; i != obj["language"][selected]["Files"].Count; i++)
			{
				String fileNameAndPath = folderPath + "/" + obj["language"][selected]["Files"][i]["dir"] + "/" +
					obj["language"][selected]["Files"][i]["fileName"];
				FileStream stream = File.Create(fileNameAndPath);
				stream.Close();
			}
			reader.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Version 1.0.0", "About");
		}
	}
}
