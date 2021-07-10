using System;

namespace InterviewPrep
{
	public class Node<T>
	{
		public T data;

		public Node<T> next;

		public Node(T data)
		{
			this.data = data;
			this.next = null;
		}
	}

	public interface ILinkedList<T>
	{
		void InsertNode(T data);

		void InsertNodeAtEnd(T data);

		int Size();

		void DeleteNode(T Node);

		void DeleteNodeAtEnd(T Node);

		bool FindDuplicates();
	}
	class LinkedList<T> : ILinkedList<T>
	{
		Node<T> head;

		public LinkedList()
		{
			this.head = null;
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

		public void InsertNode(T data)
		{
			Node<T> node = new Node<T>(data);

			if (this.head == null)
			{
				this.head = node;
				return;
			}

			Node<T> current = new Node<T>(this.head.data);
			current.next = this.head.next;

			while (current.next != null)
			{
				current = current.next;
			}

			//current.next = node;


			//node.next = this.head;
			//this.head = node;
		}

		public void PrintList()
		{
			var current = new Node<T>(this.head.data);
			current = this.head;
			int counter = 1;

			while (current != null)
			{
				Console.WriteLine($"{counter++} ele: {current.data}");
				current = current.next;
			}

			current = this.head;

			while (current != null)
			{
				Console.Write($"{current.data} --> ");
				current = current.next;
			}
		}

		public void InsertNodeAtEnd(T data)
		{
			throw new NotImplementedException();
		}

		public int Size()
		{
			throw new NotImplementedException();
		}
	}
}
