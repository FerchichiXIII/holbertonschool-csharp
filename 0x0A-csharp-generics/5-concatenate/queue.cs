using System;

class Queue<T>
{
    int count;
    Node head;
    Node tail;

    public Queue()
    {
        this.count = 0;
        this.head = null;
        this.tail = null;
    }

    public void Enqueue(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }

        Node newNode = new Node(value);
        if (this.tail == null)
        {
            this.head = this.tail = newNode;
        }
        else
        {
            this.tail.Next = newNode;
            this.tail = newNode;
        }

        this.count++;
    }

    public T Dequeue()
    {
        if (this.head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        Node n = this.head;
        this.head = this.head.Next;
        this.count--;
        return n.Value;
    }

    public T Peek()
    {
        if (this.head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return this.head.Value;
    }

    public void Print()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node print = this.head;
        while (print != null)
        {
            Console.WriteLine(print.Value);
            print = print.Next;
        }
    }

    public string Concatenate()
    {
        if (this.head == null)
        {
            return "";
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            throw new InvalidOperationException("Concatenate() is for a queue of Strings or Chars only.");
        }

        string str = "";
        Node node = this.head;
        while (node != null)
        {
            str += node.Value + " ";
            node = node.Next;
        }

        return str;
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
