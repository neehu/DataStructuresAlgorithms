using DataStructuresExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPracticeProblems
{
    public class CyclicList
    {
        public Node Head = null;
        public HashSet<Node> Nodes= new HashSet<Node>();
        public void Add(int data)
        {
            var newNode = new Node(data);
            var current = Head;
            if(current == null)
            {
                Head = newNode;
                newNode.Next = Head;
                return;
            }

            while(current.Next != Head)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Next = Head;
            Nodes.Add(newNode);
        }
    }
}
