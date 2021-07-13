using System;

namespace InterviewPrep
{
    class LinkedList<T> : ILinkedList<T>
    {
        public Node<T> head;
        private int size;

        public LinkedList()
        {
            this.head = null;
        }


        /// <summary>
        /// This function inserts a new node at the front of the existing list.
        /// Takes a param T data as input.
        /// Time Complexity == O(1)
        /// </summary>
        public void InsertAtFront(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data cannot be null");
            }

            var new_node = new Node<T>(data);
            new_node.next = this.head;
            this.head = new_node;
            this.size++;
            return;
        }

        /// <summary>
        /// This function inserts a new node after the given node.
        /// Takes a param T data as input.
        /// Time Complexity == O(1)
        /// </summary>
        public void InsertAfterNode(Node<T> prev, T data)
        {
            if (prev == null)
            {
                throw new ArgumentNullException("Previous node cannot be null");
            }

            var new_node = new Node<T>(data);
            new_node.next = prev.next;
            prev.next = new_node;
            this.size++;
        }

        /// <summary>
        /// This function inserts a new node at the end of the linked list.
        /// Takes a param T data as input.
        /// Time Complexity == O(N)
        /// </summary>
        public void InsertNodeAtEnd(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Data cannot be null");
            }

            var new_node = new Node<T>(data);

            if (this.head == null)
            {
                this.head = new_node;
                return;
            }

            var end_node = this.head;
            while (end_node.next != null)
                end_node = end_node.next;

            end_node.next = new_node;
            this.size++;
        }


        /// <summary>
        ///	Deletes the first occuring key in the linked list if exists.
        /// </summary>
        public void DeleteNode(T key)
        {
            // Keep track of the current node and the previous node.
            // if current node has matching key then we update the
            // nodes by deleting the current node and linking the prev
            // node the the current node's next.

            // To make this efficient we can access head first and delete 
            // if the value exists and return if the head is null.

            if (this.head == null) return;

            Node<T> current = this.head, prev = null;

            if (current.data.Equals(key))
            {
                this.head = current.next;
                this.size--;
                return;
            }

            while (current != null && !current.data.Equals(key))
            {
                prev = current;
                current = current.next;
            }

            if (current == null) return; // No value found with existing key.

            // Link current's next to prev's next to delete the current item.
            prev.next = current.next;
            this.size--;
        }

        /// <summary>
        ///	Deletes the first occuring key in the linked list if exists.
        /// </summary>
        public void DeleteNodeRecursive(Node<T> head, T key)
        {
            if (head == null) return; // No value has been found.

            if (head.data.Equals(key))
            {
                var current = head;
                head = head.next;
                this.size--;
                this.head = head;
                return;
            }

            DeleteNodeRecursive(head.next, key);
        }

        /// <summary>
        ///	Returns true if any duplicate value exists in a linked list.
        /// </summary>
        public bool FindDuplicates()
        {
            return false;
        }


        /// <summary>
        ///	Prints the linked list from head to last node.
        /// </summary>
        public void PrintList()
        {
            // if (this.head == null) return;

            var current = new Node<T>(this.head.data);
            current = this.head;

            while (current != null)
            {
                Console.Write($"{current.data}");

                if (current.next != null)
                    Console.Write(" --> ");

                current = current.next;
            }

            Console.WriteLine();
        }

        /// <summary>
        ///	Prints the linked list from head to last node using recursive strategy.
        /// </summary>
        public void PrintRecursive(Node<T> head)
        {
            if (head == null) return;

            PrintRecursive(head.next);
            Console.WriteLine($"{head.data}");
        }

        /// <summary>
        ///	Gets the size of the linked list.
		/// Time complexity == O(1)
        /// </summary>
        public int Size()
        {
            Console.WriteLine($"Size : {this.size}");
            return this.size;
        }
    }
}
