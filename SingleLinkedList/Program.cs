using SingleLinkedList;

class Programm
{
    static void Main(string[] args)
    {
        SingleLinkedList.SingleLinkedList singleLinkedList = new SingleLinkedList.SingleLinkedList();
        singleLinkedList.InsertFirst(2);
        singleLinkedList.InsertFirst(3);
        singleLinkedList.InsertFirst(4);
        singleLinkedList.InsertFirst(5);
        singleLinkedList.printAllNodes();

        singleLinkedList.InsertLast(1);
        singleLinkedList.printAllNodes();

        singleLinkedList.DeleteAt(2);
        singleLinkedList.printAllNodes();

        singleLinkedList.InsertAt(2, 2);
        singleLinkedList.printAllNodes();

        Console.Write(singleLinkedList.First());
    }
}
