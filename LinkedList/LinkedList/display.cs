using System;
namespace LinkList
{
    public class display
    {
        public display()
        {
            
        }

        public void DisplayOptions(){

            bool option = true;
            while (option)
            {
                Console.WriteLine("*************Linked List********************");
                Console.WriteLine("1.Display list");
                Console.WriteLine("2.Counting the number of nodes");
                Console.WriteLine("3.Searching for element");
                Console.WriteLine("4.Insert in empty list/Insert in the begginging of the list");
                Console.WriteLine("5.Insert a node at the end of the list");
                Console.WriteLine("6.Insert a node after a specified node");
                Console.WriteLine("7.Insert a node before a specified node");
                Console.WriteLine("8.Insert a node at a given position");
                Console.WriteLine("9.Delete first node");
                Console.WriteLine("10.Delete last node ");
                Console.WriteLine("11.Delete anynode  ");
                Console.WriteLine("12.Reverse the list");
                Console.WriteLine("13.Bubble sort by exchanging data");
                Console.WriteLine("14.Bubble sort by exchanging links");
                Console.WriteLine("15.mergeSort");
                Console.WriteLine("16.Insert Cycle");
                Console.WriteLine("17.Detect Cycle");
                Console.WriteLine("18.Remove Cycle");
                Console.WriteLine("19.Quit");
                Console.WriteLine();
                Console.Write("Your Choice: ");


                int c = Convert.ToInt32(System.Console.ReadLine());

                //  x.display();
                switch (c)
                {

                    case 1:
                        list.display();
                        break;
                    case 2:
                        list.countingNodes();
                        break;
                    case 3:
                        Console.WriteLine("Enter an Element to search");
                        int search = Convert.ToInt32(Console.ReadLine());
                        list.search(search);
                        break;
                    case 4:
                        Console.WriteLine("Enter an Element to insert at the beggingin");
                        int data = Convert.ToInt32(Console.ReadLine());
                        list.insertInBegginging(data);
                        break;
                    case 5:
                        Console.WriteLine("Enter an Element to insert at the end");
                        int endOfList = Convert.ToInt32(Console.ReadLine());
                        list.insertAtEnd(endOfList);
                        break;
                    case 6:
                        Console.WriteLine("Enter a data you want to insert After ");
                        int insertAfter = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter a data you want to insert after {insertAfter}");
                        int datatoInsert = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfterSpecified(insertAfter, datatoInsert);
                        break;
                    case 7:
                        Console.WriteLine("Enter a data you want to insert Before");
                        int insertBefore = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Enter a data you want to insert before {insertBefore} ");
                        int datatoInsertBefore = Convert.ToInt32(Console.ReadLine());
                        list.InsertBeforeSpecified(insertBefore, datatoInsertBefore);
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        option = false;
                        break;

                    default:
                        Console.WriteLine(" Please Make an entry");
                        break;
                }
                // Console.Read();
            }

        }
    }
}
