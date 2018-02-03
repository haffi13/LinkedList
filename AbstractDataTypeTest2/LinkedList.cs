using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypeTest2
{
    class LinkedList
    {
        private class ListItem
        {
            public object Item { get; }
            public ListItem Next { get; set; }

            public ListItem(object o)
            {
                Item = o;
                Next = null;
            }

            public override string ToString()
            {
                return Item.ToString();
            }
        }

        private ListItem firstItem = null;

        private ListItem lastItem = null;

        private int itemCount = 0;

        public int Count
        {
            get { return itemCount; }
        } 

        public object First { get { return firstItem; } }//First and last return null if the list is empty
        public object Last { get { return lastItem; } }
        public bool ListIsEmpty
        {
            get { return itemCount == 0; }
        }


        public void InsertFirst(object o)
        {
            ListItem itemToAdd = new ListItem(o);
            if(firstItem == null)
            {
                firstItem = new ListItem(itemToAdd);
                lastItem = firstItem; 
            }
            else
            {
                
                    for (int i = 0; i < Count; i++)
                    {
                        itemToAdd.Next = firstItem;
                    }
                
                firstItem = itemToAdd;
            }
            itemCount++;
        }

        public void InsertLast(object o)
        {
            ListItem itemToAdd = new ListItem(o);
            if(lastItem == null)
            {
                InsertFirst(itemToAdd);//last item is instanciated in InsertFirst is there is no previous item in the list
            }
            else
            {
                ListItem currentLast = lastItem;
                currentLast.Next = itemToAdd;
                lastItem = itemToAdd;
                itemCount++;
            }
        }
        
        public object Items(int index)
        {
            ListItem temp = firstItem;
            object ret = temp;
            if (index < 0)
            {
                //exception - might return a message but that's probably not correct
                return null;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                    ret = temp;
                }
                return ret;
            }
        }

        public void RemoveAt(int index)
        {
            ListItem temp = firstItem;

            if (index < 0 || index >= Count)
            {
                if (ListIsEmpty)
                {
                    firstItem = null;
                }
                Console.WriteLine("Removal not possible");
            }
            else if(index == 0)
            {
                firstItem = temp.Next;
                itemCount--;
            }
            else
            {
                for (int i = 0; i < index-1; i++) //index-1 cuz I want to get the item before the item I want to remove
                {
                    temp = temp.Next;//gets the list item before the item to remove
                }
                temp.Next = temp.Next.Next;//sets the next list item after the list item before the item to remove as the item after the item to remove
                itemCount--;
            } 
        }

        public override string ToString()
        {
            string ret = string.Empty;
            ListItem listItem = firstItem;
            for (int i = 0; i < Count; i++)
            {
                    ret += "|" + listItem.ToString();
                    listItem = listItem.Next;
            }
            return ret;
        }
    }
}