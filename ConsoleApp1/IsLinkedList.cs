using DataStructuresExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class IsLinkedList
    {
        public  static bool?  CheckWithHead(Node Head)
        {
            if (Head == null)
            {
                return null;
            }

            var current = Head;

            for(var i = 0; ; i = i + 1)
            {
                current = current.Next;
                if (current == null) return true;

                if (current.Next == Head) return false;
            }
        }

        public static Node CheckWithNode(Node head)
        {
            var fastPointer = head;
            var slowPointer = head;
            bool loopExists = false;

            while(fastPointer!=null && fastPointer.Next != null)
            {
                fastPointer = fastPointer.Next.Next;
                slowPointer = slowPointer.Next.Next;
                if(fastPointer == slowPointer)
                {
                    loopExists = true;
                    break;
                }
            }
            if (loopExists)
            {
                slowPointer = head;
                while(fastPointer != slowPointer)
                {
                    fastPointer = fastPointer.Next;
                    slowPointer = slowPointer.Next;
                }
                return slowPointer;
            }
            return null;
        }
        public static bool? CheckUsingHashTable(Node Head)
        {
             if (Head == null) return null;
            var nodePointers = new HashSet<Node>();
            var current = Head;
            while(current.Next != null)
            {
                if (nodePointers.Contains(current.Next))
                {
                    return false;
                }
                nodePointers.Add(current.Next);
                current = current.Next;
            }
            return true;
        }
    }
}
