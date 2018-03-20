namespace Generics {
    public class LinkedList
    {
        private class Node
        {
            // private class Node exists only within LinkedList
            public int Value { get; set; }
            public Node Next { get; set; }

            public Node(int value) {
                Value = value;
                Next = null;
            }
        }

        // private variable head is the first node 
        // of the list or null if list is empty
        private Node head;

        // property Count returns the number of nodes in list
        public int Count {
            get {
                if (head == null) {
                    return 0;
                }
                int count = 1;
                Node current = head;
                while (current.Next != null) {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        // Constructor
        public LinkedList() {
            head = null;
        }

        // Add a node at the end of the list
        public void Add(int value) {
            if (head == null) {
                head = new Node(value);
                return;
            }
            Node current = head;
            while (current.Next != null) {
                current = current.Next;
            }
            current.Next = new Node(value);
        }

        // return a string representation of the list
        public string GetString() {
            if (head == null) {
                return "[]";
            }
            string result = "[";
            Node current = head;
            while (current.Next != null) {
                result += $"{current.Value}, ";                    
                current = current.Next;
            }
            result += $"{current.Value}]";
            return result;
        }
    }
}