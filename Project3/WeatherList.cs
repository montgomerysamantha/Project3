using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class WeatherList : IList
    {
        private Node<WeatherData> _head;
        private Node<WeatherData> _tail;
        private int _size;

        public int Count => _size;

        object IList.this[int index]
        {
            get
            {
                int count = 0;
                Node<WeatherData> temp = _head;
                while (temp != null)
                {
                    if (count == index)
                    {
                        return temp.Data;
                    }
                    temp = temp.Next;
                    count++;
                }

                throw new ArgumentOutOfRangeException();
            }
            set
            {
                int count = 0;
                Node<WeatherData> temp = _head;
                while (temp != null)
                {
                    if (count == index)
                    {
                        temp.Data = (WeatherData)value;
                        return;
                    }
                    temp = temp.Next;
                    count++;
                }

                throw new ArgumentOutOfRangeException();
            }
        }

        public WeatherList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public WeatherList(WeatherList w)
        {
            //copy constructor that takes in another WeatherList object
            // and creates a new linked list that is a copy of the parameter list
            
            if (w.Count == 0)
            {
                _head = null;
                _tail = null;
                _size = 0;
            }
            else
            {
                _head = new Node<WeatherData>(w._head.Data);
                _size = 1;
                Node<WeatherData> tempOld = _head;
                Node<WeatherData> temp = w._head.Next;
                while (temp != null)
                {
                    Node<WeatherData> tempNew = new Node<WeatherData>(temp.Data);
                    tempOld.Next = tempNew;
                    tempOld = tempOld.Next;
                    temp = temp.Next;

                    if (temp != null)
                    {
                        _size++;
                    }
                }
                _tail = tempOld;
            }
        }


        public void Add(WeatherData val)
        {
            Node<WeatherData> n = new Node<WeatherData>(val);
            if (_size == 0) //if our list is empty 
            {
                _head = n;
                _tail = n;
            }
            else
            {
                _tail.Next = n;
                _tail = n;
            }

            _size++; //always increment the size because we added to the list
        }

        //filter the nodes in this list to only include those dates between start and end (inclusive)
        public void FilterRange(DateTime start, DateTime end)
        {
            if (_size == 0) //if the list is empty
            {
                return;
            }
            while (_head.Data.Date.CompareTo(start) < 0)
            {
                _head = _head.Next;
            }
            Node<WeatherData> temp = _head;
            while (temp.Next.Data.Date.CompareTo(end) < 0)
            {                
               temp = temp.Next;
            }
            _tail = temp;
            _tail.Next = null;
            //update size
            _size = (end - start).Days + 1;
            //if the list is empty

        }

        //filter the nodes in this list subject to temperature, if min is true
        // filter the list to only include those less than or equal to temperature
        //if min is false, filter the list to only include those greater than or equal to 
        //temperature
        public void FilterTemp(int temperature, bool min)
        {
            if (_size == 0) //if the list is empty
            {
                return;
            }
            if (min) //include only those less than or equal to temperature
            {
                
                Node<WeatherData> temphead = new Node<WeatherData>(null);
                Node<WeatherData> temp = temphead;
                temphead.Next = _head;
                while (temp.Next != null)
                {
                    if (temp.Next.Data._avgTemp > temperature)
                    {
                        temp.Next = temp.Next.Next;
                        if (temp.Next == null)
                        {
                            _tail = temp;
                        }
                        _size--;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                _head = temphead.Next;
            }
            else //include only those greater than or equal to temperature
            {
                Node<WeatherData> temphead = new Node<WeatherData>(null);
                Node<WeatherData> temp = temphead;
                temphead.Next = _head;
                while (temp.Next != null)
                {
                    if (temp.Next.Data._avgTemp < temperature)
                    {
                        temp.Next = temp.Next.Next;
                        if (temp.Next == null) //if we deleted the tail
                        {
                            _tail = temp;
                        }
                        _size--;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
                _head = temphead.Next;
            }
        }

        //filter the list to only include those dates whose month and day match givenDate
        public void FilterDateHistory(DateTime givenDate)
        {
            if (_size == 0) return;
            Node<WeatherData> temphead = new Node<WeatherData>(null);
            Node<WeatherData> temp = temphead;
            temphead.Next = _head;
            while (temp.Next != null)
            {
                //if the month and day DO NOT match, remove from the WeatherList
                if (temp.Data.Date.Month != givenDate.Month && temp.Data.Date.Day != givenDate.Day)
                {
                    temp.Next = temp.Next.Next;

                    if (temp.Next == null)
                    {
                        _tail = temp;
                    }
                    _size--;
                }
                else
                {
                    temp = temp.Next;
                }
            }
            _head = temphead.Next;

        }

        public bool Contains(WeatherData value)
        {
            Node<WeatherData> temp = _head;
            while (temp != null)
            {
                if (temp.Data.Equals(value))
                {
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        public void CopyTo(WeatherData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(WeatherData item)
        {
            if (_size == 0) return false;

            //value is not in list

            //is the value in the head?
            if (_head.Data.Equals(item))
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
                _size--;
                return true;
            }

            Node<WeatherData> temp = _head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.Equals(item))
                {
                    temp.Next = temp.Next.Next;
                    if (temp.Next == null)
                    {
                        _tail = temp;
                    }

                    _size--;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public IEnumerator<WeatherData> GetEnumerator()
        {
            return new ListEnumerator(_head);
        }

        private class ListEnumerator : IEnumerator<WeatherData>
        {
            private Node<WeatherData> _cur;

            public ListEnumerator(Node<WeatherData> first)
            {
                _cur = new Node<WeatherData>(default(WeatherData));
                _cur.Next = first;
            }

            public WeatherData Current
            {
                get
                {
                    return _cur.Data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                //return whether or not there is more data
                if (_cur == null) return false;
                _cur = _cur.Next;
                if (_cur == null) return false;
                else return true;
            }

            public void Reset()
            {

            }

            public void Dispose()
            {

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public int IndexOf(WeatherData value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, WeatherData item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            //Remove((WeatherData)value);
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        //begin inner Node class, stores generic types
        private class Node<T>
        {
            private T _data;
            private Node<T> _next;

            public Node(T d)
            {
                _data = d;
                _next = null;
            }

            public T Data
            {
                get
                {
                    return _data;
                }
                set
                {
                    _data = value;
                }
            }

            public Node<T> Next
            {
                get
                {
                    return _next;
                }
                set
                {
                    _next = value;
                }
            }
        }
        // end inner Node class
    }
}
