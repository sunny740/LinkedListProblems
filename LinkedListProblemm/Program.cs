using LinkedListProblemm;
using System;
namespace LinkedListProblem;
class program
{
    public static void Main(string[] args)
    {
        LinkList list = new LinkList();
        bool check = true;
        Console.WriteLine("1.Simple Link List");
        while (check)
        {
            Console.WriteLine("Take An Option To Execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    list.Add(30);
                    list.Add(56);
                    list.Add(70);
                    break;
            }
        }
    }
}