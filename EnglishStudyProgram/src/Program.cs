using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EnglishStudyProgram {

	struct Book {
		public string title;
		public string author;
		public Book(string title, string author) { this.title = title; this.author = author; }
	}

	class Program {
		public Book[] books;

		public Program(int examNum) {
			switch(examNum) {
				case 1:
					InitBooksExam1();
					break;
				case 2:
					Console.WriteLine("Exam 2, TODO");
					break;
				default:
					Console.WriteLine("Invalid exam num...");
					break;
			}
		}

		public void MainProgram() {
			string input = "";
			bool quit = false;
			BookTestContent testList = new BookTestContent();
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
						testList.SortByTitle();

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

		public void InitBooksExam1() {
			const int numBooks = 4;
			books = new Book[numBooks];
			books[0] = new Book("Incidents in the Life of a Slave Girl", "Harriet A. Jacobs");
			books[1] = new Book("Pudd'nhead Wilson", "Mark Twain");
			books[2] = new Book("Ethan Frome", "Edith Wharton");
			books[4] = new Book("The Sun Also Rises", "Ernest Hemingway");
		}

		public void AddBookMenu(List<BookTestContent> list) {

		}

		public void TestMenu() {
			BookTestContent testContent = new BookTestContent();
			List<string> infoList = new List<string>();
			infoList.Add("First bullet point");
			infoList.Add("Second bullet point");
			infoList.Add("Third bullet point");
			testContent.AddTestContent("Title", "Author", "This is a test question", infoList);

			var options = new JsonSerializerOptions {
				WriteIndented = true,
			};

			string jsonString = JsonSerializer.Serialize(testContent, options);
			Console.WriteLine(jsonString);
			System.IO.File.WriteAllText("../../json/testingData.json", jsonString);

		}

		static void Main(string[] args) {
			Program program = new Program(1);
			program.MainProgram();

			Console.ReadKey();
		}

	}
}
