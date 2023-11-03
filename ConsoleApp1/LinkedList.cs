using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresExamples
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head;
        public HashSet<Node> Nodes = new HashSet<Node>();
        public void Display()
        {
            var current = Head;
            while (current.Next != null)
            {
                Console.WriteLine(current.Data + "->");
                current = current.Next;
            }
            Console.WriteLine("");
        }
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new(newNode.Data);
            }
            Nodes.Add(newNode);
        }
        public Node FindTheKthNodeinAList(int k)
        {
            if (Head.Next == null || k < 0)
                return null;
            Dictionary<int, Node> nodePositions = new Dictionary<int, Node>();
            int position = 1;
            Node current = Head;

            while (current.Next != null)
            {
                nodePositions[position] = current;
                position++;
                current = current.Next;
            }
            int length = position - 1;
            if (k > length)
            {
                return null;
            }
            return nodePositions[length - k + 1];
        }

        public Node FindTheKthNodeinAListWithoutHashTable(int k)
        {
            if (Head.Next == null || k < 0)
            {
                return null;
            }
            var current = Head;
            var position = 1;

            while (current.Next != null)
            {
                current = current.Next;
                position++;
            }

            var pointer = 1;
            current = Head;
            while (pointer != position - k)
            {
                current = current.Next;
                pointer++;
            }
            return current;
        }

        public Node FindKthNodeRefactored(int k)
        {
            if (Head == null || k < 0)
            {
                return null;
            }

            var first = Head;
            var second = Head;

            for (var i = 0; i < k; i++)
            {
                if (first.Next == null)
                {
                    return null;
                }
                first = first.Next;
            }

            while (first.Next != null)
            {
                first = first.Next;
                second = second.Next;
            }
            return second;
        }

        public  void Insert(int data)
        {
            var newNode = new Node(data);
            if(Head == null)
            {
                Head = newNode;
            }
            var current = Head;
            while(current.Next != null &&  newNode.Data > current.Next.Data) {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Reverse()
        {
            var current = Head;
            Node previous = null;
            while(current.Next != null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
        }

        public Node Intersect(Node head,Node head2)
        {
            var nodePointers = new HashSet<Node>();
            var current = head;
            while(current != null)
            {
                nodePointers.Add(current);
                current = current.Next;
            }
             current = head2;
            while(!nodePointers.Contains(current))
            {
                current = current.Next;
            }
            return current;
        }

        public Node IntersectByPointers(Node head,Node head2)
        {
            var current = head;
            var position = 1;

            while(current != null)
            {
                current = current.Next;
                position++;
            }

            current = head2;
            var position2 = 1;
            while(current != null)
            {
                current = current.Next;
                position2++;
            }

            var lengthDiff = Math.Abs(position - position2);
            current = head;
            var current2 = head2;
            if (position > position2)
            {
                for (int i = 0; i < lengthDiff; i++)
                {
                    current = current.Next;
                }
            }
            else
            {
                for (int i = 0;i < lengthDiff; i++)
                {
                    current2 = current2.Next;
                }
            }
            
            while(current != null && current2 != null)
            {
                if(current == current2)
                {
                    break;
                }
                current2 = current2.Next;
                current = current.Next;
            }
            return current;
        }

        public  Node Middle()
        {
            var current = Head;
            var position = 1;
            while(current != null)
            {
                current = current.Next;
                position++;
            }

            current = Head;
            var length = position;
            position = 1;

            while(current != null)
            {
                if(position == Math.Round((decimal)length/2))
                {
                    break;
                }
                current = current.Next;
                position++;
            }
            return current;
        }

        public Node MiddleUsingHashSet()
        {
            var current = Head;
            var next = Head;
            while(next != null && next.Next != null)
            {
                next = next.Next.Next;
                current = current.Next;
            }
            return current;
        }
    }
}
