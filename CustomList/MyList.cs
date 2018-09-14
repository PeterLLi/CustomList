using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T> : IEnumerable
    {
        public T[] myArray = new T[0];

        public T this[int index]
        {
            get
            {
                if (index < Count)
                {
                    return myArray[index];
                }
                else
                {
                    throw (new IndexOutOfRangeException());
                }
            }

            set
            {
                if (index < Count)
                {
                    myArray[index] = value;
                }
                else
                {
                    throw (new IndexOutOfRangeException());
                }
            }
        }
        
        //Add function
        public void Add(T addItem)
        {
            int currentCount = Count;

            T[] newArray = new T[currentCount + 1];

            for (int i = 0; i < currentCount; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[currentCount] = addItem;
            myArray = newArray;
        }

        //Remove function
        public bool Remove(T removeItem)
        {
            int currentCount = Count;

            T[] myNewArray = new T[currentCount - 1];

            for (int i = 0; i < currentCount; i++)
            {
                if (myArray[i].Equals(removeItem))
                {
                    for (int j = 0; j < i; j++)
                    {
                        myNewArray[j] = myArray[j];
                    }
                    for (int k = i + 1; k < currentCount; k++)
                    {
                        myNewArray[k - 1] = myArray[k];
                    }
                    myArray = myNewArray;
                    return true;
                }
            }

            return false;
        }

        //Iterable list
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return myArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Counter for the list
        public int Count
        {
            get
            {
                int counter = 0;
                foreach (T element in myArray)
                {
                    counter++;
                }
                return counter;
            }
        }

        //Overload the + operator
        public static MyList<T> operator +(MyList<T> myList1, MyList<T> myList2)
        {
            MyList<T> myNewList = new MyList<T>();

            for (int i = 0; i < myList1.Count; i++)
            {
                myNewList.Add(myList1[i]);
            }

            for (int i = 0; i < myList2.Count; i++)
            {
                myNewList.Add(myList2[i]);
            }
            
            return myNewList;
        }

        //Overload the -  operator
        public static MyList<T> operator -(MyList<T> primaryList, MyList<T> subtractList)
        {
            MyList<T> myNewList = new MyList<T>();
            bool hold;
            for (int i = 0; i < primaryList.Count; i++)
            {
                hold = true;
                for (int j = 0; j < subtractList.Count; j++)
                {
                    if (primaryList[i].Equals(subtractList[j]))
                    {
                        hold = false;
                    }
                }
                if (hold)
                {
                    myNewList.Add(primaryList[i]);
                }
            }
            return myNewList;
        }

        //Overload the ToString() operator
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < Count; i++)
            {
                output.Append(myArray[i]);
            }
            return output.ToString();
        }

        //Zip two files together
        public MyList<T> Zip(MyList<T> newList)
        {
            MyList<T> list = new MyList<T>();
            int zipCounter;

            if (this.Count >= newList.Count)
            {
                zipCounter = this.Count;
            }
            else
            {
                zipCounter = newList.Count;
            }

            for (int i = 0; i < zipCounter; i++)
            {
                if (i < this.Count) { list.Add(this[i]); }
                if (i < newList.Count) { list.Add(newList[i]); }
            }
            return list;
        } 
    }
}
