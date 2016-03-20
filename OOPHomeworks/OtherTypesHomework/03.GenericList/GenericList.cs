using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _03.GenericList
{
        [VersionAttribute(1 ,2)]
    public class GenericList<T>  where T : IComparable
    {
        private const int defaultCapacity = 16;
        private int count;
        T[] array;

        public GenericList(int capacity = defaultCapacity)
        {
            this.array = new T[capacity];
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (this.count == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }

                if (index < 0 || index >= this.count)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
                }

                return this.array[index];
            }

            set
            {
                this.array[index] = value;
            }

        }

        public void Add(T element)
        {
            array[this.count] = element;
            count++;
            if (count == Capacity)
            {
                Capacity = Capacity * 2;

                T[] newList = new T[Capacity];
                int counter = 0;
                for (int i = 0; i < count; i++)
                {
                    newList[counter] = array[i];
                    counter++;
                }
                array = newList;
            }
        }

        public void InsertElementAt(T element, int index)
        {
            count++;
            if (count == Capacity)
            {
                Capacity = Capacity * 2;
            }
            int counter = 0;
            T[] newList = new T[Capacity];
            for (int i = 0; i < index; i++)
            {
                newList[i] = array[i];
                counter++;
            }
            newList[counter] = element;
            counter++;
            for (int i = counter; i < count; i++)
            {
                newList[i] = array[i - 1];
            }
            array = newList;

        }

        public void RemoveElementAtIndex(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index...");
            }
            T[] newList = new T[Capacity];
            int counter = 0;
            for (int i = 0; i < count; i++)
            {
                if (i != index)
                {
                    newList[counter] = array[i];
                    counter++;
                }
            }
            array = newList;
            count--;
        }

        public T ElementAtIndex(int index)
        {
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index...");
            }
            return array[index];
        }

        public void Clear()
        {
            this.count = 0;
            array = new T[Capacity];
        }

        public int? IndexOf(T element)
        {
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                return null;
            }
            else
            {
                return index;
            }
        }

        public bool Contains(T element)
        {
            bool containsValue = false;
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(element))
                {
                    containsValue = true;
                    break;
                }
                else
                {
                    containsValue = false;
                }
            }
            return containsValue;
        }

        public  T Min() 
        {
            T minElement = this.array[0];
            for (int i = 0; i < count; i++)
            {
                T currentElement = this.array[i];
                if (currentElement.CompareTo(minElement) < 0)
                {
                    minElement = currentElement;
                }
            }
            return minElement;
        }

        public  T Max() 
        {
            T maxElement = this.array[0];
            for (int i = 0; i <  count; i++)
            {

                T currentElement = this.array[i];
                if (currentElement.CompareTo(maxElement) > 0)
                {
                    maxElement = currentElement;
                }
            }
            return maxElement;
        }


        public override string ToString()
        {
            T[] tempList = array.Take(count).ToArray();
            return String.Join(", ", tempList);
        }

        public string Version()
        {
            var versionNum = string.Empty;
            var type = typeof(GenericList<T>);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (var attr in allAttributes)
            {
                var attribute = attr as VersionAttribute;
                if (attribute != null)
                {
                    var version = attribute;
                    versionNum = string.Format("GenericList v.{0}.{1}", version.Major, version.Minor);
                }
            }

            return versionNum;
        }

    }
}
