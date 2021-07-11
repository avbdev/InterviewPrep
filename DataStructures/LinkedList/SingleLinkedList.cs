using System;

namespace InterviewPrep
{
	class LinkedList<T> : ILinkedList<T>
	{
		public Node<T> head;

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
			if(data == null) 
			{
				throw new ArgumentNullException("Data cannot be null");
			} 

			var new_node = new Node<T> (data);
			new_node.next = this.head;
			this.head = new_node;
			return;
		}

		/// <summary>
		/// This function inserts a new node after the given node.
		/// Takes a param T data as input.
		/// Time Complexity == O(1)
		/// </summary>
		public void InsertAfterNode(Node<T> prev, T data) 
		{
			if(prev == null) 
			{
				throw new ArgumentNullException("Previous node cannot be null");
			} 

			var new_node = new Node<T>(data);
			new_node.next = prev.next;
			prev.next = new_node;
		}

		/// <summary>
		/// This function inserts a new node at the end of the linked list.
		/// Takes a param T data as input.
		/// Time Complexity == O(N)
		/// </summary>
		public void InsertNodeAtEnd(T data)
		{
			if(data == null) 
			{
				throw new ArgumentNullException("Data cannot be null");
			}
			
			var new_node = new Node<T>(data);

			if(this.head == null) 
			{
				this.head = new_node;
				return ;
			}

			var end_node = this.head;
			while(end_node.next != null)
				end_node = end_node.next;
			
			end_node.next = new_node;
		}


		public void DeleteNode(T Node)
		{

		}

		public void DeleteNodeAtEnd(T Node)
		{

		}

		public bool FindDuplicates()
		{
			return false;
		}


		public void PrintList()
		{
			var current = new Node<T>(this.head.data);
			current = this.head;
			
			while (current != null)
			{
				Console.Write($"{current.data}");

				if(current.next != null)
				Console.Write(" --> ");

				current = current.next;
			}

			Console.WriteLine();
		}

		public void PrintRecursive(Node<T> head)
		{
			if (head == null) return;

			PrintRecursive(head.next);
			Console.WriteLine($"{head.data}");
		}

		public int Size()
		{
			var current = this.head;
			var counter = 0;

			while (current != null)
			{
				counter++;
				current = current.next;
			}

			Console.WriteLine($"Size : {counter}");

			return counter;
		}
	}
}
