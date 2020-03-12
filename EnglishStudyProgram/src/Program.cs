using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EnglishStudyProgram {

	class Program {
		static void Main(string[] args) {
			Console.Write("Press anything to start program:");
			Console.Read();
			TestMenu();
			Console.Write("Press anything to exit...");
			Console.Read();
		}

		static void TestMenu() {
			BookTestContent testContent = new BookTestContent();
			List<string> infoList = new List<string>();
			infoList.Add("First bullet point");
			infoList.Add("Second bullet point");
			infoList.Add("Third bullet point");
			testContent.AddTestContent(0, "This is a test question", infoList);

			var options = new JsonSerializerOptions {
				WriteIndented = true,
			};

			string jsonString = JsonSerializer.Serialize(testContent, options);
			Console.WriteLine(jsonString);
			System.IO.File.WriteAllText("../../json/testingData.json", jsonString);

		}
	}
}
