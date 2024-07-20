using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProgram
{
    internal class СhartList
    {
        private MyChart[] c;
        private int count;
        private int capacity;

        public int Count { get => count; }
        public int Capacity { get => capacity; }
        public MyChart[] Charts { get => c.Take(count).ToArray(); }
        public СhartList(int capacity)
        {
            this.capacity = capacity;
            c = new MyChart[capacity];
            count = 0;
        }

        public MyChart this[int index]
        {
            get { return c[index]; }
            set { c[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return c[i];
            }
        }
        public void AddRange(IEnumerable<MyChart> items)
        {
            foreach (MyChart item in items)
            {
                Add(item);
            }
        }
        public void Add(MyChart person)
        {
            if (capacity == count)
            {
                capacity += 3;
                MyChart[] cN = new MyChart[capacity];
                Array.Copy(c, cN, c.Length);
                c = cN;
            }
            c[count] = person;
            count++;
        }
        public void Remove()
        {
            RemoveAt(count - 1);
        }
        public void RemoveAt(int index)
        {
            if (count == 0)
            {
                return;
            }
            if (count == 1)
            {
                c[0] = null;
                count = 0;
                return;
            }
            MyChart[] cNew = new MyChart[count - 1];
            for (int i = 0; i < index; i++)
            {
                cNew[i] = c[i];
            }
            for (int i = index + 1; i < count; i++)
            {
                cNew[i - 1] = c[i];
            }
            c = cNew;
            count--;
        }
        public override string ToString()
        {
            return count + " / " + capacity;
        }
    }
}
