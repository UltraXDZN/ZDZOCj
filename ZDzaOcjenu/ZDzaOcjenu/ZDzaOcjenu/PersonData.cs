using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDzaOcjenu
{
    public class PersonData
    {
        string name;
        int age;
        int personID;

        public PersonData(string name, int age, int ID)
        {
            Name = name;
            Age = age;
            personID = ID;
        }
        public PersonData() { personID = 0; }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int PersonID { get => personID; set => personID = value; }
    }
}
