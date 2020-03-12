using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace EnglishStudyProgram {
	class BookInfo {
		public int bookID { get; set; }
		public string keyInfo { get; set; }
		public List<string> infoList { get; set; }

		public BookInfo(int bookID, string keyInfo, List<string> infoList) {
			this.bookID = bookID;
			this.keyInfo = keyInfo;
			this.infoList = infoList;
		}

		public string getJson() {
			string json = "";

			return json;
		}
	}

	class Program {
		static void Main(string[] args) {
		}
	}
}
