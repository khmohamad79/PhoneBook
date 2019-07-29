using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public List<string> PhoneNumbers { get; set; }
        public DateTime BirthDate { get; set; }

        public Person();
        public override string ToString();
        public TimeSpan TimeToBirthday();
    }
}
