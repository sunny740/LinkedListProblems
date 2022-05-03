using LinkedListProblemm;
using System;
namespace LinkedListProblem;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" *** Welcome to Linked List Program ***\n ");
        bool end = true;
        Console.WriteLine("\n1.Add Data\n2.Reverse Data\n3.InsertData\n4.Remove First Element\n5.Remove Last Element\n6.Search Node\n7.Insert New Data\n8.Delete Node\n9.End Of Program ");
        while (end)
        {
            LinkList list = new LinkList();
            Console.WriteLine("\nChoose An Option : ");
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
                    list.AddReverseOrder(70);
                    list.Add(30);
                    list.Add(56);
                    list.Display();
                    break;
                case 3:
                    list.Add(56);
                    list.Add(70);
                    int num = list.Search(56);
                    list.InsertParticularPosition(num + 1, 30);
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
                    list.InsertParticularPosition(newNode + 1, 40);
                    list.Display();
                    break;
                case 8:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    int node = list.Search(30);
                    list.InsertParticularPosition(node + 1, 40);
                    list.Display();
                    Console.WriteLine("\n\nElement Deleted SuccessFully");
                    list.DltNodeParticularPosition(node + 1);
                    list.Display();
                    break;
                case 9:
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