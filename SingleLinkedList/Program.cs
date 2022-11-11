using SingleLinkedList;

class Programm
{
    static void Main(string[] args)
    {
        SingleLinkedList.SingleLinkedList singleLinkedList = new SingleLinkedList.SingleLinkedList();
        
        singleLinkedList.InsertFirst(22);
        singleLinkedList.InsertFirst(44);
        singleLinkedList.InsertFirst(11);
        singleLinkedList.InsertFirst(55);
        singleLinkedList.InsertFirst(33);
        
        singleLinkedList.printAllNodes();
        Console.WriteLine(singleLinkedList.Count());
    }
}