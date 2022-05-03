using LinkedListProblemm;
using System;
namespace LinkedListProblem;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(" **** Welcome to Linked List Program ***\n");
        LinkList list = new LinkList();
        bool check = true;
        Console.WriteLine("1.Simple Linked List\n2.Add in Reverse Order\n3.Insert number at Particular Position\n4.Delete a Number at Particular position\n5.Delete Last Node\n6.Search For The Element");
        while (check)
        {
            Console.WriteLine("Take an Option To Execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    list.Add(30);
                    list.Add(56);
                    list.Add(70);
                    break;
                case 2:
                    list.AddInReverseOrder(56);
                    list.AddInReverseOrder(30);
                    list.AddInReverseOrder(70);
                    break;
                case 3:
                    list.Add(56);
                    list.Add(70);
                    int a = list.Search(56);
                    list.InsertAtParticularPosition(a + 1, 30);
                    list.Display();
                    break;
                case 4:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    Console.WriteLine("Enter The Position of The Element");
                    int position = Convert.ToInt32(Console.ReadLine());
                    list.DeleteNodeAtParticularPosition(position);
                    list.Display();
                    break;
                case 5:
                    list.Add(56);
                    list.Add(30);
                    list.Add(70);
                    list.RemoveLastNode();
                    list.Display();
                    break;
                case 6:
                    list.Add(30);
                    list.Add(56);
                    list.Add(70);
                    int value = list.Search(30);
                    list.Display();
                    Console.WriteLine("Element is in" + value);
                    break;
                default: break;
            }
        }
    }
}