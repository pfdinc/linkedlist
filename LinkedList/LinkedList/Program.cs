using System;

namespace LinkList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            SingleLinkedList list = new SingleLinkedList();
            display listOptions = new display();
            list.generateList();
            listOptions.DisplayOptions();



          
        }
    }
}