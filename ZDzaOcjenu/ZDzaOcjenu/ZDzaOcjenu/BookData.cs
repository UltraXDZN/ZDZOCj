using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDzaOcjenu
{
    public class BookData
    {
        string bookName;
        string bookAuthor;
        int bookID;
        string bookAmount;

        public BookData(string bookName, string bookAuthor, int ID)
        {
            BookName = bookName;
            BookAuthor = bookAuthor;
            bookID = ID;
        }

        public BookData() { bookID = 0; }

        public string BookName { get => bookName; set => bookName = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public string BookAmount { get => bookAmount; set => bookAmount = value; }
        public int BookID { get => bookID; set => bookID = value; }
    }
}
