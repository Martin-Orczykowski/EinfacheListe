using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheListe
{
    internal class SimpleList<T>
    {
        private Entry<T> head;
        private Entry<T> tail;

        public bool IsEmpty()
        {
            if(head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(T data)
        {
            if (IsEmpty())
            {
                head = new Entry<T>(data);
                tail = head;
            }
            else
            {
                tail.Next = new Entry<T>(data);
                tail = tail.Next;
            }
        }

        public int Count()
        {
            Entry<T> tmp = head;
            int temp = 0;
            while (tmp != null)
            {
                temp++;
                tmp = tmp.Next;
            }
            return temp;
        }

        public void Dequeue(T data)
        {
            Entry<T> tmp1 = null;
            Entry<T> tmp2 = head;

            while(tmp2 != null)
            {
                if(object.Equals(data, tmp2.Data))
                {
                    if(tmp1 == null)
                    {
                        head = head.Next;
                    }
                    else
                    {
                        tmp1.Next = tmp2.Next;
                    }
                }

                tmp1 = tmp2;
                tmp2 = tmp2.Next;
            }
        }

        public T[] Array()
        {
            T[] arr = new T[Count()];
            Entry<T> tmp = head;

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = tmp.Data;
                tmp = tmp.Next;
            }

            return arr;
        }

        public bool Search(T data)
        {
            Entry<T> tmp = head;
            bool result = false;

            while(tmp != null)
            {
                if(object.Equals(data, tmp.Data))
                {
                    result = true;
                }
                tmp = tmp.Next;
            }

            return result;
        }

        public T this[int index]
        {
            
            get 
            {
                if(index >= Array().Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return Array()[index]; 
            }
        }
    }
}
