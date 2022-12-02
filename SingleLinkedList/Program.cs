using Common;

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
        Console.WriteLine(singleLinkedList.ToString());
        Console.WriteLine(singleLinkedList.Count());

        singleLinkedList.SetSortStrategy(new BubbleSort());
        singleLinkedList.Sort();
        Console.WriteLine(singleLinkedList.ToString());
    }
}