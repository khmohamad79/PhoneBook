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

        public Person()
        {

        }
        public override string ToString()
        {
            // temp string to generate output
            string result;

            // add main details to result
            result = string.Format("FirstName: '{0}' LastName: '{1}' Address: '{2}' Email: '{3}' BirthDate: '{4}'",
                FirstName, LastName, Address, Email, BirthDate.ToShortDateString());

            // add each phonenumber to result (if exists)
            if (PhoneNumbers.Count > 0)
            {
                result += '\n';
                result += "PhoneNumbers: ";
                foreach(string item in PhoneNumbers)
                {
                    result += "'" + item + "',";
                }
            }

            // skip to newline
            result += '\n';

            return result;
        }
        public TimeSpan TimeToBirthday()
        {
            TimeSpan result = DateTime.Today.Subtract(new DateTime(DateTime.Today.Year, BirthDate.Month, BirthDate.Day));
            if (result.TotalHours > 0)
            {
                result = DateTime.Today.Subtract(new DateTime(DateTime.Today.AddYears(1).Year, BirthDate.Month, BirthDate.Day));
            }
            return result;
        }
    }
}
