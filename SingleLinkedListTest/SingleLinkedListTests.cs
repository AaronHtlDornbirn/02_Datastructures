using NUnit.Framework;
using Common;

namespace SingleLinkedListTests
{
    public class SingleLinkedListTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestLinkedListCount_AddItems_ReturnsCorrectCount()
        {
            SingleLinkedList.SingleLinkedList list= new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLinkedListInsertFirst_AddItems_ReturnsCorrectNumberOfElements()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLinkedList_InsertLast_ReturnsCorrectLastElement()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertLast(7);
            Assert.AreEqual(7, list.Last().Data);
        }

        [Test]
        public void TestLinkedListInserAfter_AddItems_ReturnsCorrectOrderdList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertAfter(2, 7);
            object current = list.First();
            Assert.AreEqual(7, list.First().next.next.Data);
        }

        [Test]
        public void TestLinkedList_GetNode_ReturnsCorrectDataOfElement()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(2, list.GetElement(2).Data);
        }

        [Test]
        public void TestLinkedList_DeleteNode_ReturnsCorrectNumberOfElements()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertLast(7);
            list.DeleteNode(list.GetElement(3));
            Assert.AreEqual(3, list.Count());
        }

        [Test]
        public void TestLSwitchNode_SecondIsFirstNode_ReturnsSwitchedList() 
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast(1);
            list.InsertLast(2);
            Node node1 = list.GetElement(1);
            Node node2 = list.GetElement(2);
            list.SwitchNodes(node1, node2);
            Assert.AreEqual(list.First().Data, 2);
            Assert.AreEqual(list.Last().Data, 1);
        }

        [Test]
        public void TestSwitchedNodes_NodeDoesntExist_Error()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast(1);
            list.InsertLast(2);
            Node node1 = list.GetElement(3);
            Node node2 = list.GetElement(1);
            list.SwitchNodes(node1, node2);
            Assert.AreEqual(list.head.Data, 1);
        }
    }
}