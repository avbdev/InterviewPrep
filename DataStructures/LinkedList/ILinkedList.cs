namespace InterviewPrep
{
    public interface ILinkedList<T>
	{
		void InsertAtFront(T data);
		
		void InsertAfterNode(Node<T> prev, T data);
		
		void InsertNodeAtEnd(T data);

		int Size();

		void DeleteNode(T Node);

		void DeleteNodeAtEnd(T Node);

		bool FindDuplicates();
	}
}