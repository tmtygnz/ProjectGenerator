using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace ProjectGenerator.src
{
	partial class backend
	{
		private String genFilePath = @"C:\Users\josti\source\repos\ProjectGenerator\ProjectGenerator\Generator Files\gen.json";
		public dynamic load()
		{
			StreamReader reader = new StreamReader(genFilePath);
			String genFileString = reader.ReadToEnd();
			dynamic obj = JsonConvert.DeserializeObject<dynamic>(genFileString);
			return obj;
		}
	}
}
