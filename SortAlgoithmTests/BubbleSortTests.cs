using Common;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class BubbleSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestBubbleSort_RandomOrder_CorrectOrder()
        {
            SingleLinkedList.SingleLinkedList linkedlist = new SingleLinkedList.SingleLinkedList();
            linkedlist.InsertFirst(22);
            linkedlist.InsertFirst(55);
            linkedlist.InsertFirst(33);
            linkedlist.InsertFirst(44);
            linkedlist.InsertFirst(11);

            linkedlist.SetSortStrategy(SortFactory.StrategyGenerator("BubbleSort"));
            linkedlist.Sort();

            Assert.AreEqual(linkedlist.head.Data, 11);
            Assert.AreEqual(linkedlist.head.next.Data, 22);
            Assert.AreEqual(linkedlist.head.next.next.Data, 33);
            Assert.AreEqual(linkedlist.head.next.next.next.Data, 44);
            Assert.AreEqual(linkedlist.head.next.next.next.next.Data, 55);
        }

        [Test]
        public void TestBubbleSortDesc_RandomOrder_CorrectOrder()
        {
            SingleLinkedList.SingleLinkedList linkedlist = new SingleLinkedList.SingleLinkedList();
            linkedlist.InsertFirst(22);
            linkedlist.InsertFirst(55);
            linkedlist.InsertFirst(33);
            linkedlist.InsertFirst(44);
            linkedlist.InsertFirst(11);

            linkedlist.SetSortStrategy(SortFactory.StrategyGenerator("BubbleSort"));
            linkedlist.SortDesc();

            Assert.AreEqual(linkedlist.head.Data, 55);
            Assert.AreEqual(linkedlist.head.next.Data, 44);
            Assert.AreEqual(linkedlist.head.next.next.Data, 33);
            Assert.AreEqual(linkedlist.head.next.next.next.Data, 22);
            Assert.AreEqual(linkedlist.head.next.next.next.next.Data, 11);
        }
    }
}





