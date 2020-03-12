using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishStudyProgram {
	class BookInfo {
		public int BookID { get; set; }
		public string KeyInfo { get; set; }
		public List<string> InfoList { get; set; }

		public BookInfo(int bookID, string keyInfo, List<string> infoList) {
			BookID = bookID;
			KeyInfo = keyInfo;
			InfoList = infoList;
		}
	}
	class BookTestContent {
		public List<BookInfo> TestContent { get; set; }
		public BookTestContent() {
			TestContent = new List<BookInfo>();
		}

		public void AddTestContent(int bookID, string keyInfo, List<string> infoList) {
			BookInfo bookInfo = new BookInfo(bookID, keyInfo, infoList);
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

	}
}
