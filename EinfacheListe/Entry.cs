using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinfacheListe
{
    internal class Entry<T>
    {
        private T data;
        private Entry<T> next;

        public T Data
        {
            get 
            { 
                return data; 
            }
            set
            {
                data = value;
            }
        }

        public Entry<T> Next
        {
            get
            {
                return next;
            }
            set 
            {
                next = value; 
            }
        }

        public Entry(T data)
        {
            this.data = data;
        }
    }
}
