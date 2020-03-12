using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudyProgram {
	class BookInfo {
		public string BookTitle { get; set; }
		public string BookAuthor { get; set; }
		public string KeyInfo { get; set; }
		public List<string> InfoList { get; set; }

		public BookInfo(string bookTitle, string bookAuthor, string keyInfo, List<string> infoList) {
			BookTitle = bookTitle;
			BookAuthor = bookAuthor;
			KeyInfo = keyInfo;
			InfoList = infoList;
		}
		public BookInfo() {
			BookTitle = "";
			BookAuthor = "";
			KeyInfo = "";
			InfoList = new List<string>();
		}
	}
	class BookTestContent {
		public List<BookInfo> TestContent { get; set; }
		public BookTestContent() {
			TestContent = new List<BookInfo>();
		}

		public void AddTestContent(string bookTitle, string bookAuthor, string keyInfo, List<string> infoList) {
			BookInfo bookInfo = new BookInfo(bookTitle, bookAuthor, keyInfo, infoList);
			TestContent.Add(bookInfo);
		}

		public BookInfo GetBookInfo(int index) {
			BookInfo bookInfo = null;
			try {
				bookInfo = TestContent.ElementAt(index);
			} catch(ArgumentNullException) {
				Console.WriteLine("Tried to pass in a null index...");
			} catch(ArgumentOutOfRangeException) {
				Console.WriteLine("Tried to access an index out of range: index=" + index);
			}
			return bookInfo;
		}

		public void SortByTitle() {
			TestContent = TestContent.OrderBy(o => o.BookTitle).ToList();
		}

	}
}
