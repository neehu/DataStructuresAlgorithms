using DataStructuresExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPracticeProblems
{
    public static class SortedLists
    {
        public static LinkedList Merge(LinkedList list1,LinkedList list2)
        {
            var node1 = list1.Head;
            var node2 = list2.Head;
            var mergedList = new LinkedList();

            if (list1.Head == null && list2.Head == null)
            {
                return new LinkedList();
            }

            if (list1.Head == null)
            {
                return list2;
            }

            if(list2.Head == null)
            {
                return list1;
            }

            while(node1 != null && node2 != null)
            {
               if(node1.Data <= node2.Data)
                {
                    mergedList.Add(node1.Data);
                    node1 = node1.Next;
                }
               else
                {
                    mergedList.Add(node2.Data);
                    node2 = node2.Next;
                }
            }

            while(node1 != null)
            {
                mergedList.Add(node1.Data);
                node1 = node1.Next;
            }
            while (node2 != null)
            {
                mergedList.Add(node2.Data);
                node2 = node2.Next;
            }
            return mergedList;
        }
    }
}
