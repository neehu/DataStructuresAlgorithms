// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using DataStructuresExamples;
using System.Text;

//var mergeString = MergeStringsAlternatively.MergeAlternately("abc", "p");
//Console.WriteLine(mergeString);

//var result = GreatestCommonDivisorOfStrings.GcdOfStrings("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
//Console.WriteLine(result);

LinkedList list = new LinkedList();
list.Add(10);
list.Add(20);
list.Add(30);
list.Add(40);
list.Add(50);
list.Add(60);
int k = 3;
list.Display();
//var kthNode = list.FindTheKthNodeinAList(k);
//var kthNode = list.FindTheKthNodeinAListWithoutHashTable(k);
var kthNode = list.FindKthNodeRefactored(k);

if (kthNode != null)
{
    Console.WriteLine($"{k}th Node from the end is {kthNode.Data}");
}
else
{
    Console.WriteLine("The list has fewer than k nodes");
}


var cyclicList = new CyclicList();
cyclicList.Add(100);
cyclicList.Add(200);
cyclicList.Add(300);
cyclicList.Add(400);
cyclicList.Add(500);
cyclicList.Add(600);
cyclicList.Add(700);

var isLinkedList = IsLinkedList.CheckWithHead(list.Head);
var isCyclicList = !IsLinkedList.CheckWithHead(cyclicList.Head);
Console.WriteLine($"Check for Linked list is sucessfull {isLinkedList}");
Console.WriteLine($"Check for Cyclic list is sucessfull {isCyclicList}");
Console.WriteLine();
Console.WriteLine();

isLinkedList = IsLinkedList.CheckUsingHashTable(list.Head);
isCyclicList = !IsLinkedList.CheckUsingHashTable(cyclicList.Head);
Console.WriteLine($"Check for Linked list using HashTable is sucessfull {isLinkedList}");
Console.WriteLine($"Check for Cyclic list using Hash Table is sucessfull {isCyclicList}");

list.Insert(35);
list.Display();

list.Reverse();
list.Display();


LinkedList list1 = new LinkedList();
list1.Add(1);
list1.Add(2);
list1.Add(3);
list1.Add(4);
list1.Add(5);
list1.Add(6);
list1.Add(7);


LinkedList list2 = new LinkedList();
list2.Add(4);
list2.Add(5);

list2.Head.Next.Next = list1.Head.Next;
//var intersectionNode = list1.Intersect(list1.Head, list2.Head);
var intersectionNode = list1.IntersectByPointers(list1.Head, list2.Head);
//var middleOfTheNode = list1.Middle();
var middleOfTheNode = list1.MiddleUsingHashSet();

Console.WriteLine($"Intersection point is {intersectionNode.Data}");
Console.WriteLine($"Middle of the list is {middleOfTheNode.Data}");
