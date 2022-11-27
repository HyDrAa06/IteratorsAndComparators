using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator1
{
    public class Iterators<T> : IEnumerable<T>
    {
        private List<T> elements;
        int index;

        public List<T> Elements
        {
            get { return elements; }
            set { elements = value; }
        }
        

       

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T element in elements) 
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool HasNext()
        {
            return index + 1 < elements.Count;
        }

        public bool Move()
        {
            if(index < elements.Count)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if(elements.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            Console.WriteLine(elements[index]);
        }
        public void PrintAll()
        {
            if (elements.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }
            List<T> temp1 = new List<T>();
            foreach (T element in elements) 
            {
                temp1.Add(element);
            }
            Console.WriteLine(String.Join(" ", temp1));
        }
    }
}

