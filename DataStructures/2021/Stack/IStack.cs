namespace InterviewPrep
{
    interface IStack<T>
    {
        T Pop();
        void Push(T data);

        bool IsEmpty();

        T Peek();
    }
}