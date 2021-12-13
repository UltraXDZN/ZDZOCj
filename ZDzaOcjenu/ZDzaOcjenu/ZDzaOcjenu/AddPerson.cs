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
    public partial class AddPerson : Form
    {
        AddPersonEvent newPerson;
        public AddPerson(AddPersonEvent person)
        {
            InitializeComponent();
            newPerson = person;
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            try
            {
                PersonData person = new PersonData(nameTB.Text, int.Parse(ageTB.Text), int.Parse(idTB.Text));
                newPerson.Invoke(person);
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
