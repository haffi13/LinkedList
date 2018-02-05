using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypeTest2 
{
    public class Names : IComparable<Names>
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public int CompareTo(Names other)
        {
            if (this.Number > other.Number) return -1;
            else if (this.Number == other.Number) return 0;
            else return 1;
        }
    }
}
