    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypeTest2
{
    public enum Gender { Male, Female }

    public class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public int CompareTo(Person other)
        {
            string firstLetterInThisName = this.FullName.Substring(0, 1);//could also just use firstName, seems in the tests that they are just comparing the first letter in the names
            string firstLetterInOtherName = other.FullName.Substring(0, 1);

            return 0;


        }

        public override string ToString()
        {
            return $"{Id}: {FullName} ({Gender}), {Age} years";
        }
    }
}
