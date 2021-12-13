using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ZDzaOcjenu
{
    public delegate void AddBookEvent(BookData book);
    public delegate void AddPersonEvent(PersonData person);

    public partial class Form1 : Form
    {
        public AddPersonEvent newPerson;
        public AddBookEvent newBook;

        public List<BookData> bookDatas = new List<BookData>();
        public List<PersonData> personDatas = new List<PersonData>();

        public Form1()
        {
            InitializeComponent();
            newPerson += new AddPersonEvent(InputFormDataPerson);
            newBook += new AddBookEvent(InputFormDataBook);
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            AddPerson inputForm = new AddPerson(newPerson);
            inputForm.Show();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook inputForm = new AddBook(newBook);
            inputForm.Show();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {

        }

        public void InputFormDataPerson(PersonData person)
        {
            personDatas.Add(person);
            SaveToXML("people.xml", personDatas);
        }

        public void InputFormDataBook(BookData book)
        {
            bookDatas.Add(book);
            SaveToXML("books.xml", bookDatas);
        }

        void SaveToXML(string filename, List<PersonData> data)
        {
            var xml = new XElement("People", data.Select(x => new XElement("Person",
                                               new XAttribute("Id", x.PersonID),
                                               new XAttribute("Name", x.Name),
                                               new XAttribute("Age", x.Age))));

            XmlSerializer serialiser = new XmlSerializer(typeof(List<PersonData>));
            filename = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDoc‌​uments),
                "ZadatakZaOcjenu",
                filename);
            TextWriter filestream = new StreamWriter(filename);
            Directory.CreateDirectory(filename);
            serialiser.Serialize(filestream, data);
            filestream.Close();
        }

        void SaveToXML(string filename, List<BookData> data)
        {
            var xml = new XElement("Books", data.Select(x => new XElement("Book",
                                               new XAttribute("Id", x.BookID),
                                               new XAttribute("Name", x.BookName),
                                               new XAttribute("Author", x.BookAuthor))));

            XmlSerializer serialiser = new XmlSerializer(typeof(List<BookData>));
            filename = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDoc‌​uments),
                "ZadatakZaOcjenu",
                filename);
            TextWriter filestream = new StreamWriter(filename);
            Directory.CreateDirectory(filename);
            serialiser.Serialize(filestream, data);
            filestream.Close();
        }
    }
}
