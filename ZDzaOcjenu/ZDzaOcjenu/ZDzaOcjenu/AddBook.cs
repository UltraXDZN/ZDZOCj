using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZDzaOcjenu
{
    
    public partial class AddBook : Form
    {
        AddBookEvent newBook;

        public AddBook(AddBookEvent book)
        {
            InitializeComponent();
            newBook = book;
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            try
            {
                BookData book = new BookData(nameTB.Text, authorTB.Text, int.Parse(idTB.Text));
                newBook.Invoke(book);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
