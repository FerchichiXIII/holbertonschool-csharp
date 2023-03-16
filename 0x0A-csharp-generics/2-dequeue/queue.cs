using System;

class Queue<T>
{
    /// <summary>
    /// Queue Class
    /// </summary>
    int count;

    public Node head
    {
        /// <summary>
        /// Node head
        /// </summary>
        get;
        set;
    }

    public Node tail
    {
        ///<summary>
        ///node tail
        /// </summary>
        get;
        set;
    }

    public string CheckType()
    {
        /// <summary>
        /// check the type
        /// </summary>
        return (typeof(T).ToString());
    }

    public void Enqueue(T value)
    {
        /// <summary>
        /// Enqueue
        /// </summary>
        Node newNode = new Node(value);
        if (this.tail == null)
        {
            this.head = this.tail = newNode;
            count += 1;
        }
        else
        {
            this.tail.Next = newNode;
            this.tail = newNode;
            count += 1;
        }

    }
    public T Dequeue()
    {
        /// <summary>
        /// method Dequeue
        /// </summary>
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node n= this.head;
        this.head = this.head.Next;
        count -= 1;
        return n.Value;

    }

    public int Count()
    {
        /// <summary>
        /// count
        /// </summary>
        return this.count;
    }
    


    public class Node
    {
        /// <summary>
        /// class Node
        /// </summary>
        T value;
        Node next = null;

        public T Value
        {
            /// <summary>
            /// value of T
            /// </summary>
            get => this.value;
            set
            {
                this.value = value;
            }
        }
        public Node Next
        {
            /// <summary>
            /// node next
            /// </summary>
            get => this.next;
            set
            {
                this.next = value;
            }
        }

        public Node(T value)
        {
            /// <summery>
            /// node of T value
            /// </summery>
            this.value = value;
            this.next = null;
        }
    }
}
