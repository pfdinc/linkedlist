using System;
namespace LinkList
{
    /*
     * p.next refures to the next node on the list 
     * p.info refures to the data stored within the current node

    */
    public class SingleLinkedList
    {

        //this where the beggining of the 
        internal Node start;

        //constructor 
        public SingleLinkedList()
        {
            start = null;

        }//close SingleLinkedList()



        //this will display how many is in the list 
        public void display()
        {
            //this is 
            Node position = start;

            //if the beggingin is empty 
            if (position == null)
            {
                Console.WriteLine("The List is empty:");
            }

            Console.Write("The List Is: ");
            int count = 0;


            while (position != null)
            {
                //i feel like this part of the code is a repeat?? if(p==null) 
                if (start == null)
                    break;
                count++;
                Console.Write(position.info + " ");
                position = position.next;
            }


            Console.WriteLine();
            Console.WriteLine("There are {0} Nodes in the list", count);

        }//end of disply()




        /*
        //this will search 
        */

        public bool search(int x)
        {

            Node position = start;
            int count = 1;

            while (position != null)
            {
                //if the information matches X
                if (position.info == x)
                {
                    Console.WriteLine("{0} was found on position {1} ", x, count);
                    return true;
                }

                if (position.next.info != x)
                {
                    Console.WriteLine(" {0} was not found", x);
                    return false;
                }
                //next
                position = position.next;
                count++;
            }
            return false;

        }//closr Search(int x)

        //this will go through all of the elemnts on the list
        public void traversal()
        {
            Node position = start;
            if (start == null)
            {
                Console.WriteLine("the list is empty:");
                return;
            }

            Console.Write("output of numbers:");

            while (position != null)
            {
                //next
                position = position.next;
                Console.Write(position.info + " ");
            }

        }// close traversal()


        //this will count the nodes
        public void countingNodes()
        {

            Node position = start;
            int count = 0;
            if (position == null)
                Console.WriteLine("There are no elements on the list");



            //iterate til the end of teh lit
            while (position != null)
            {

                //next
                position = position.next; //couting each cycle 
                count++;

            }
            Console.WriteLine("Number of Elements on the List = " + count);
        }// close countingNodes()


        //this will insert at the front of the list 
        public void insertInBegginging(int data)
        {

            Node temp = new Node(data);

            temp.next = start;
            start = temp;

        }//close insertInBegginging(int data)

        public void CreateList(int data)
        {

            Node temp = new Node(data);


            if (start == null)
            {

                start = temp;
            }
            else
            {

                temp.next = start;
                start = temp;
            }


        }
        public void InsertAfterSpecified(int data, int x)
        {
            /*
             * Note:
             * if the list is empty 
             * if value not found
            */
            Node temp = new Node(data);
            //initiate start to start
            Node position = start;

            //iterate untl the position is null
            while (position != null)
            {

                //if value is found we break out of the loop
                if (position.info == x)
                {

                    break;
                }

                //refures to the next node
                position = position.next;
            }

            if (start == null)
            {

                Console.WriteLine("The list is empty");

            }
            else
            {

                temp.next = position.next;
                position.next = temp;
            }




        }

        public void InsertBeforeSpecified(int data, int x)
        {

            Node temp = new Node(data);

            Node position = start;

            while (position != null)
            {
                //exception thrown here.. check why
                if (position.next.info == x)
                    break;
                //reffures to the next node on the list
                position = position.next;
            }

            if (start == null)
            {

                Console.WriteLine("List is empty");

            }
            else
            {
                temp.next = position.next;
                position.next = temp;

            }



        }

        //this will insert the value at the end of the list
        public void insertAtEnd(int data)
        {

            Node temp = new Node(data);
            Node position = start;
            if (position == null)
            {

                temp.next = start;
                start = temp;
                return;
            }

            while (position.next != null)
            {

                position = position.next;

                //Console.WriteLine("im here");

                if (position.next == null)
                {
                    // Console.WriteLine("im here too");

                    position.next = temp;
                    break;

                }

            }
        }//close insertAtEnd(int data)


        public void generateList()
        {

            int count = 1;
            Console.Write("What is the size of your list: ");
            int listSize = Convert.ToInt32(Console.ReadLine());

            while (listSize > count)
            {

                Console.Write($"incert data in list [{count+1}] : ");
                int data = Convert.ToInt32(Console.ReadLine());

                CreateList(data);

                count++;
            }

        }
    }
}
