using LinkedListProblemm;
using System;
namespace LinkedListProblem;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" *** Welcome to Linked List Program ***\n ");
        bool end = true;
        Console.WriteLine("\n1.Add Data\n2.Reverse Data\n3.Insert Data\n4.Remove First Element\n5.Remove Last Element\n6.Search Node\n7.Insert New Data\n8.Delete Node At Particular Position\n9.Sorted Element\n10.End Of Program ");
        while (end)
        {
            LinkList list = new LinkList();
            Console.WriteLine("\nEnter Option For Exicute The Program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Display();
                    break;
                case 2:
                    list.ReverseOrder(70);
                    list.Add(30);
                    list.Add(56);
                    list.Display();
                    break;
                case 3:
                    list.Add(56);
                    list.Add(70);
                    int num = list.Search(56);
                    list.InsertAtParticularPosition(num + 1, 30);
                    list.Display();
                    break;
                case 4:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RmvFirstNode();
                    list.Display();
                    break;
                case 5:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RmvLastNode();
                    list.Display();
                    break;
                case 6:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.Search(30);
                    break;
                case 7:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    int newNode = list.Search(30);
                    list.InsertAtParticularPosition(newNode + 1, 40);
                    list.Display();
                    break;
                case 8:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    int node = list.Search(30);
                    list.InsertAtParticularPosition(node + 1, 40);
                    list.Display();
                    Console.WriteLine("\n\nElement Delete SuccessFully");
                    list.DltNodeAtParticularPosition(node + 1);
                    list.Display();
                    break;
                case 9:
                    SortingLinkList<int> sortingList = new SortingLinkList<int>();
                    sortingList.AddNode(56);
                    sortingList.AddNode(30);
                    sortingList.AddNode(40);
                    sortingList.AddNode(70);
                    Console.WriteLine("Original List: ");
                    sortingList.DisplaySort();
                    sortingList.SortOrderedList();
                    Console.WriteLine("Final Sorted List: ");
                    sortingList.DisplaySort();
                    break;
                case 10:
                    end = false;
                    Console.WriteLine("Program Is Ended.");
                    break;
                default:
                    Console.WriteLine("Enter The Correct Option");
                    break;
            }
        }
    }
}