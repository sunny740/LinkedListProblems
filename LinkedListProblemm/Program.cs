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
        Console.WriteLine("1.Simple Link List\n2.Add in Reverse Order\n");
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
            }
        }
    }
}