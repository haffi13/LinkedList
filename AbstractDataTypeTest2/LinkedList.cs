using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDataTypeTest2
{
    public class LinkedList
    {
        private class ListItem
        {
            public object Item { get; }
            public ListItem Next { get; set; }

            public ListItem(object o)
            {
                Item = o;
                //Next = null;
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

        public object First
        {
            get
            {
                object result = null;
                if(!ListIsEmpty)
                {
                    result = firstItem.Item;
                }
                return result;
            }
        }
        public object Last
        {
            get
            {
                object result = null;
                if(!ListIsEmpty)
                {
                    result = lastItem.Item;
                }
                return result;
            }
        }
        public bool ListIsEmpty
        {
            get { return itemCount == 0; }
        }
        
        public object Items(int index)
        {
            object result = null;
            ListItem temp = firstItem;
            //object ret = temp;
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
                /*//why throw exception if you can handle it without letting anything happen
                 Console.Writeline("There is no item at this index");
                 */
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                    //ret = temp.Item;
                }
                result = temp.Item;
            }
            return result;
        }

        public void InsertFirst(object o)
        {
            ListItem itemToAdd = new ListItem(o);
            if (firstItem == null)
            {
                firstItem = itemToAdd;
                lastItem = firstItem;
            }
            else
            {
                itemToAdd.Next = firstItem;
                firstItem = itemToAdd;
            }
            itemCount++;
        }

        public void InsertLast(object o)
        {
            ListItem itemToAdd = new ListItem(o);
            if (lastItem == null)
            {
                firstItem = itemToAdd; 
                lastItem = firstItem;   
            }
            else
            {
                lastItem.Next = itemToAdd;  //set null value-ið eftir lastItem sem itemToAdd
                lastItem = itemToAdd;       //þá er það orðið last item og ég set það sem last item
                lastItem.Next = null;       //set lastItem.Next sem null
            }
            itemCount++;
        }


        public void RemoveAt(int index)
        {
            if(index < itemCount && index >= 0)
            {
                //ListItem temp = firstItem;
                if (index == 0)
                {
                    firstItem = firstItem.Next;
                    //itemCount--;
                }
                else
                {
                    ListItem temp = firstItem;
                    for (int i = 0; i < index - 1; i++)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = temp.Next.Next;
                    //itemCount--;

                    if (index == itemCount - 1)
                    {
                        lastItem = temp;
                        lastItem.Next = null;
                        //itemCount--;
                    }
                }
                
                itemCount--;
            }
            else
            {
                firstItem = null;
                lastItem = null;
            }
        }
        
        public void Sort()
        {
            if (!ListIsEmpty)
            {
                for (int i = 0; i < Count -1; i++) //can maybe do count - 2
                {
                    ListItem thisItem = null;
                    ListItem otherItem = firstItem;

                    //IComparable => -1 | 0 | 1 -> lessThan| equal | moreThan

                    for (int j = 0; j < Count - 1; i++) //eða count -2 ?  CompareTo is not implemented, always returns 0
                    {
                        Names thisName;
                        Names otherName;
                        thisName = (Names)thisItem.Item;
                        otherName = (Names)otherItem.Item;

                        if (thisName.CompareTo(otherName) > 0)
                        {
                            ListItem temp = otherItem.Next;
                            otherItem.Next = temp.Next.Next;
                            temp.Next = otherItem;
                            if(thisItem == null)
                            {
                                firstItem = temp;
                            }
                            else
                            {
                                thisItem.Next = temp;
                            }
                        }
                        else
                        {

                        }

                    }
                }
                
            }

            //for (int i = 0; i < arrLenght - 2; i++)           bubble sort algorithm
            //{
            //    for (int j = 0; j < arrLenght - 1; j++)
            //    {
            //        int current = arr[j];
            //        int next = arr[j + 1];
            //        if (current > next)
            //        {
            //            arr[j] = next;
            //            arr[j + 1] = current;
            //        }
            //    }
            //    arrLenght--;//as there is not need to sort alredy sorted values
            //}
        }



        public override string ToString()
        {
            string ret = string.Empty;
            ListItem listItem = firstItem;
            for (int i = 0; i < Count; i++)
            {
                if(i < Count -1)
                {
                    ret += listItem.ToString() + "|";
                }
                else
                {
                    ret += listItem.ToString();
                }
                listItem = listItem.Next;
            }
            return ret;
        }
    }
}