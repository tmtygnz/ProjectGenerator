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
				Console.Beep(1222,100);
				String v = obj["language"][i]["Name"];
				LangSlect.Items.Add(v);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadFile();
		}
	}
}
