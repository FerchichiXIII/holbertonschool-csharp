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
    public T Dequeue()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node n = this.head;
        this.head = this.head.Next;
        count -= 1;
        return n.Value;

    }
    public T Peek()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return this.head.Value;
    }
    public void Print()
    {
        if (this.head == null)
        {
            Console.WriteLine("Queue is empty");
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
            Console.WriteLine("Queue is empty");
        }
        if (typeof(T) != typeof(string) || typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
        }
        Node node = this.head;
        string str = "";
        while(node != null)
        {
            if (node.next == null)
            {
                str += prop.value;

            }
            else
            {
                str += node.Value + " ";
            }
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
