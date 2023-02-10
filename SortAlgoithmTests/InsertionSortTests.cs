using Common;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class InsertionSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInsertionSort_RandomOrder_CorrectOrder()
        {
            SingleLinkedList.SingleLinkedList linkedlist = new SingleLinkedList.SingleLinkedList();
            linkedlist.InsertFirst(22);
            linkedlist.InsertFirst(55);
            linkedlist.InsertFirst(33);
            linkedlist.InsertFirst(44);
            linkedlist.InsertFirst(11);

            linkedlist.SetSortStrategy(SortFactory.StrategyGenerator("InsertionSort"));
            linkedlist.Sort();

            Assert.AreEqual(linkedlist.head.Data, 11);
            Assert.AreEqual(linkedlist.head.next.Data, 22);
            Assert.AreEqual(linkedlist.head.next.next.Data, 33);
            Assert.AreEqual(linkedlist.head.next.next.next.Data, 44);
            Assert.AreEqual(linkedlist.head.next.next.next.next.Data, 55);
        }

        [Test]
        public void TestInsertionSortInverse_RandomOrder_CorrectOrder()
        {
            SingleLinkedList.SingleLinkedList linkedlist = new SingleLinkedList.SingleLinkedList();
            linkedlist.InsertFirst(22);
            linkedlist.InsertFirst(55);
            linkedlist.InsertFirst(33);
            linkedlist.InsertFirst(44);
            linkedlist.InsertFirst(11);

            linkedlist.SetSortStrategy(SortFactory.StrategyGenerator("InsertionSort"));
            linkedlist.SortDesc();

            Assert.AreEqual(linkedlist.head.Data, 55);
            Assert.AreEqual(linkedlist.head.next.Data, 44);
            Assert.AreEqual(linkedlist.head.next.next.Data, 33);
            Assert.AreEqual(linkedlist.head.next.next.next.Data, 22);
            Assert.AreEqual(linkedlist.head.next.next.next.next.Data, 11);
        }
    }
}
