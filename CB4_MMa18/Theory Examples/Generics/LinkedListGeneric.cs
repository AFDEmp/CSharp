using System;

namespace Generics {
    class LinkedListGeneric<T>
    {
        // private class Node exists only within LinkedList
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
            {
                Value = value;
                Next = null;
            }
        }

        // private variable head
        // is the first node of the list or null if list is empty
        private Node<T> head;

        // property Count returns the number of nodes in list
        public int Count
        {
            get
            {
                if (head == null)
                {
                    return 0;
                }
                int count = 1;
                Node<T> current = head;
                while (current.Next != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        // Constructor
        public LinkedListGeneric()
        {
            head = null;
        }

        // Add a node at the end of the list
        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(value);
        }

        public T Get(int index) {
            // With this we make sure that index
            // points to a valid Node
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            // so our loop just cares about reaching index
            Node<T> current = head;
            int i = 0;
            while (i < index) 
            {
                current = current.Next;
                i++;
            }
            // we reached index so we return the corresponding value
            return current.Value;
        }

        public void RemoveAt(int index) {
            // With this we make sure that index
            // points to a valid Node
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            // If we want to erase the first item
            // just move the head
            if (index == 0) {
                head = head.Next;
                return;
            }
            // Else reach index and connect Node index-1 with Node index + 1
            Node<T> current = head;
            Node<T> previous = null;
            int i = 0;
            while (i < index) 
            {
                previous = current;
                current = current.Next;
            }
            previous.Next = current.Next;
            return;
        }

        // Return a string representation of the list.
        // We make use of inheritance and the fact that every class
        // inherits from base class Object
        public override string ToString()
        {
            if (head == null)
            {
                return "[]";
            }
            Node<T> current = head;
            string result = "[";
            while (current.Next != null)
            {
                result += $"{current.Value}, ";
                current = current.Next;
            }
            result += $"{current.Value}]";
            return result;
        }
    }
}