using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EnglishStudyProgram {

	class Program {
		static void Main(string[] args) {
			MainProgram();
			Console.ReadKey();
		}

		static void MainProgram() {
			string input = "";
			bool quit = false;
			List<BookTestContent> testList = new List<BookTestContent>();
			do {
				Console.WriteLine("\n1. Add test content\n2. Print test content\n3. Quit");
				Console.Write("Enter 1-3:");
				
				input = Console.ReadLine();

				switch(input) {
					case "1":
						Console.WriteLine("TODO");
						break;
					case "2":
						Console.WriteLine("TODO");
						break;
					case "3":
						quit = true;
						break;
					default:
						Console.WriteLine("Invalid input...");
						break;
				}
				
			} while(!quit);
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
