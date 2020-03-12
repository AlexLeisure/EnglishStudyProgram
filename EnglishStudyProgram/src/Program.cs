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

		public void MainProgram(BookTestContent testList) {
			string input = "";
			bool quit = false;
			//BookTestContent testList = new BookTestContent();
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
						PrintBookTc(testList);
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
			books[3] = new Book("The Sun Also Rises", "Ernest Hemingway");
		}

		public void PrintBookTc(BookTestContent testContent) {
			int counter = 1;
			foreach(Book b in books) {
				Console.WriteLine("Books:\n" + counter + ". " + b.title);
			}
			Console.Write("Choose a book: ");

			string input = Console.ReadLine();
			int indexChoice;
			while(!Int32.TryParse(input, out indexChoice) || indexChoice < 1 || indexChoice > books.Length) {
				Console.WriteLine("Invalid input...");
				Console.Write("Choose a book: ");
				input = Console.ReadLine();
			}
			indexChoice--;

			List<BookInfo> bookInfo = testContent.TestContent.FindAll(o=>o.BookTitle == books[indexChoice].title);
			foreach(BookInfo b in bookInfo) {
				Console.WriteLine("Book Title: " + b.BookTitle);
				Console.WriteLine("Book Author: " + b.BookAuthor);
				Console.WriteLine("Question: " + b.KeyInfo);
				foreach(string info in b.InfoList) {
					Console.WriteLine("\t--" + info);
				}
				Console.WriteLine("-------------------------------------------------------------");
			}
		}

		public void AddBookMenu(List<BookTestContent> list) {
			int bookID;

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

			BookTestContent testContent = new BookTestContent();
			List<string> infoList = new List<string>();
			infoList.Add("First bullet point");
			infoList.Add("Second bullet point");
			infoList.Add("Third bullet point");
			testContent.AddTestContent(program.books[0].title, program.books[0].author, "This is a test question", infoList);
			testContent.AddTestContent(program.books[0].title, program.books[0].author, "This is a test2 question", infoList);
			testContent.AddTestContent(program.books[0].title, program.books[0].author, "This is a test3 question", infoList);
			testContent.AddTestContent(program.books[0].title, program.books[0].author, "This is a test4 question", infoList);

			testContent.AddTestContent(program.books[1].title, program.books[1].author, "This is a test question", infoList);
			testContent.AddTestContent(program.books[1].title, program.books[1].author, "This is a test2 question", infoList);
			testContent.AddTestContent(program.books[1].title, program.books[1].author, "This is a test3 question", infoList);
			testContent.AddTestContent(program.books[1].title, program.books[1].author, "This is a test4 question", infoList);

			testContent.AddTestContent(program.books[2].title, program.books[2].author, "This is a test question", infoList);
			testContent.AddTestContent(program.books[2].title, program.books[2].author, "This is a test2 question", infoList);
			testContent.AddTestContent(program.books[2].title, program.books[2].author, "This is a test3 question", infoList);
			testContent.AddTestContent(program.books[2].title, program.books[2].author, "This is a test4 question", infoList);

			testContent.AddTestContent(program.books[3].title, program.books[3].author, "This is a test question", infoList);
			testContent.AddTestContent(program.books[3].title, program.books[3].author, "This is a test2 question", infoList);
			testContent.AddTestContent(program.books[3].title, program.books[3].author, "This is a test3 question", infoList);
			testContent.AddTestContent(program.books[3].title, program.books[3].author, "This is a test4 question", infoList);

			program.MainProgram(testContent);
		}

	}
}
