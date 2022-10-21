using SingleLinkedList;

class Programm
{
    static void Main(string[] args)
    {
        SingleLinkedList.SingleLinkedList singleLinkedList = new SingleLinkedList.SingleLinkedList();

        singleLinkedList.InsertFirst(1);
        singleLinkedList.InsertLast(2);
        singleLinkedList.InsertLast(3);
        singleLinkedList.InsertLast(4);
        singleLinkedList.DeleteNode(0);
        singleLinkedList.printAllNodes();

        Console.WriteLine(singleLinkedList.GetNode(4).Data);
        Console.WriteLine(singleLinkedList.Count());
    }
}