using System;


class Queue<T>
{
    int count;

    public Node head
    {
        get;
        set;
    }

    public Node tail
    {
        get;
        set;
    }

    public string CheckType()
    {
        return (typeof(T).ToString());
    }

    public void Enqueue(T value)
    {
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

    public int Count()
    {
        return this.count;
    }


    public class Node
    {
        T value;
        Node next = null;

        public T Value
        {
            get => this.value;
            set
            {
                this.value = value;
            }
        }
        public Node Next
        {
            get => this.next;
            set
            {
                this.next = value;
            }
        }

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
