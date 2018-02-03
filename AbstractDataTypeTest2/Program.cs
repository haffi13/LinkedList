using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypeTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            Names names = new Names();
            Names names1 = new Names();
            Names names2 = new Names();
            Names names3 = new Names();
            Names names4 = new Names();
            Names names5 = new Names();
            Names names6 = new Names();
            Names names7 = new Names();
            Names names8 = new Names();
            Names names9 = new Names();


            names.Name = "Lars";
            names1.Name = "Peter";
            names2.Name = "Gunnlöður";
            names3.Name = "Hafsteinn";
            names4.Name = "Lebron";
            names5.Name = "Trevor";
            names6.Name = "Kristín";
            names7.Name = "Ananas";
            names8.Name = "Last";
            names9.Name = "First";

            //remove is zero based, if you want to remove 3rd item on the list you RemoveAt(2);


            linkedList.InsertLast(names.Name);
            linkedList.InsertLast(names1.Name);
            linkedList.InsertLast(names2.Name);

            linkedList.InsertFirst(names3.Name);
            linkedList.InsertFirst(names4.Name);

            linkedList.InsertLast(names5.Name);
            linkedList.InsertLast(names6.Name);

            linkedList.InsertFirst(names7.Name);

            //linkedList.RemoveAt(0);

            linkedList.InsertLast(names8.Name);

            linkedList.InsertFirst(names9.Name);

            //linkedList.InsertFirst(" ");
            //linkedList.InsertFirst(6);//can add different data types into the list...
            //linkedList.RemoveAt(2);
            //Console.WriteLine(linkedList.Items(0));
            //Console.WriteLine(linkedList.Items(4));
            //Console.WriteLine(linkedList.Items(-1));//returns null, doesnt cause havoc

            Console.WriteLine(linkedList.ToString());

            //Console.WriteLine(linkedList.Count);

            /*for (int i = linkedList.Count; i >= 0; i--) //shows you can remove from the first position until the list is empty
            {                                           //also shows that you don't get exception if you try to remove from an empty list
                linkedList.RemoveAt(0);
                Console.WriteLine(linkedList.ToString());
            }*/

            //linkedList.RemoveAt(linkedList.Count);//shows you don't get an exception if you try to remove a item at index where there is no item 


            Console.ReadKey();
        }
    }
}
