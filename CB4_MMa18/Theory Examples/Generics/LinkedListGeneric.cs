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

        // return a string representation of the list
        public string GetString()
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