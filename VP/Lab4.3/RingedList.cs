using System.Collections;
using System;
using System.Collections.Generic;

namespace Laba4._3
{
    internal class RingedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;
        private int _maxCapacity;
        public RingedList(int maxCapacity)
        {
            _maxCapacity = maxCapacity;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0)
                    throw new ArgumentOutOfRangeException();
                if (_head != null)
                {
                    int currentIndex = 0;
                    Node<T> node = _head;
                    while (index > currentIndex)
                    {
                        node = node.Next;
                        currentIndex++;
                        if (index >= _count)
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }

                    return node.Data;
                }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (index < 0)
                    throw new ArgumentOutOfRangeException();
                if (_head != null)
                {
                    int currentIndex = 0;
                    Node<T> node = _head;
                    while (index != currentIndex)
                    {
                        node = node.Next;
                        currentIndex++;
                        if (index >= _count)
                        {
                            throw new IndexOutOfRangeException();
                        }
                    }

                    node.Data = value;
                }
            }
        }


        public void Push(T data)
        {
            if (_count >= _maxCapacity)
            {
                throw new OutOfMemoryException();
            }
            Node<T> node = new Node<T>(data);
            if (_head == null)
            {
                _head = node;
                _tail = node;
                _tail.Next = node;
            }
            else
            {
                node.Next = _head;
                _tail.Next = node;
                _tail = node;
            }
            _count++;
        }
        public T Get(int index)
        {
            return this[index];
        }

        public T Head()
        {
            if (_head == null)
                throw new Exception("List is empty");
            return _head.Data;
        }
        public int GetCount()
        {       
            return _count;
        }
        public void Clear()
        {
            _head = null;
            _count = 0;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = _head;
            do
            {
                yield return current.Data;
                current = current.Next;
            } while (current != _head);
        }
    }
}