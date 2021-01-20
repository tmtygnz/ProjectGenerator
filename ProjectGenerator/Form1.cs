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
			genFileSturct obj = JsonConvert.DeserializeObject<genFileSturct>(genFileString);
			darkLabel1.Text = obj.Language;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadFile();
		}
	}
	public class genFileSturct
	{
		public String Language { get; set; }
		public bool GitCommit { get; set; }
	}
}
