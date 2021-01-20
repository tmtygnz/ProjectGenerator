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
namespace ProjectGenerator
{
	public partial class Form1 : Form
	{
		String genFilePath = @"C:\Users\josti\source\repos\ProjectGenerator\ProjectGenerator\Generator Files\gen.json";
		public Form1()
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
				Console.Beep(1222,10);
				LangSlect.Items.Add(obj["language"][i]["Name"]);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadFile();
		}

		private void LangSlect_SelectedIndexChanged(object sender, EventArgs e)
		{
			StreamReader reader = new StreamReader(genFilePath);
			String genFileString = reader.ReadToEnd();
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(genFileString);
			int selected = LangSlect.SelectedIndex;
			if(obj["language"][selected]["gitPush"] == true)
			{
				GitBool.Checked = true;
				GitURL.Enabled = true;
			}
			if (obj["language"][selected]["gitPush"] != true)
			{
				GitBool.Checked = false;
				GitURL.Enabled = false;
			}
			if(obj["language"][selected]["openInExplorer"] == true)
			{
				OpenExp.Checked = true;
			}
			if (obj["language"][selected]["openInExplorer"] != true)
			{
				OpenExp.Checked = false;
			}

		}

		private void GitBool_CheckedChanged(object sender, EventArgs e)
		{
			if(GitBool.Checked != true)
			{
				GitURL.Enabled = false;
			}
			if (GitBool.Checked == true)
			{
				GitURL.Enabled = true;
			}
		}
	}
}
