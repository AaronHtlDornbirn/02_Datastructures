using NUnit.Framework;
using SingleLinkedList;

namespace SingleLinkedListTest
{

    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void IsertFirst_NotEmptyList_ElementAddedAtFirstPosOfList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            list.InsertFirst("second");
            var node = list.GetNode("second");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("second", node.Data);
            Assert.AreEqual(node.next.Data, "first");
        }

        [Test]
        public void IsertFirst_EmptyList_OnlyThisElementInList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            var node = list.GetNode("first");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("first", node.Data);
            Assert.AreEqual(node.next, null);
        }

        [Test]
        public void IsertLast_NotEmptyList_ElementAddedAtLastPosOfList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast("first");
            list.InsertLast("second");
            var node = list.GetNode("second");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("second", node.Data);
            Assert.AreEqual(node.next, null);
        }

        [Test]
        public void IsertLast_EmptyList_OnlyThisElementInList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            var node = list.GetNode("first");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("first", node.Data);
            Assert.AreEqual(node.next, null);
        }

        [Test]
        public void IsertAt_NotEmptyList_ElementAddedAtLastPosOfList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast("first");
            list.InsertLast("second");
            list.InsertAfter("middle", 1);
            var node = list.GetNode("middle");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            // next node should be "second"
            Assert.AreEqual("middle", node.Data);
            Assert.AreNotEqual(node.next, null);
            Assert.AreEqual(node.next.Data, "second");
        }

        [Test]
        public void DeleteNode_NoEmptyList_DeleteElement()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast("first");
            list.InsertLast("second");
            list.DeleteNode(1);
        }

        [Test]
        public void GetNode_NodeExists_ReturnsNode()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            list.InsertFirst("second");
            var node = list.GetNode("first");
            Assert.AreEqual("first", node.Data);

        }

        [Test]
        public void IsertFirst_NotEmptyList_ElementAddedAtFirstPosOfList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            list.InsertFirst("second");
            var node = list.GetNode("second");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("second", node.data);
            Assert.AreEqual(node.next.data, "first");
        }


        [Test]
        public void IsertFirst_EmptyList_OnlyThisElementInList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            var node = list.GetNode("first");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("first", node.data);
            Assert.AreEqual(node.next, null);
        }

        [Test]
        public void IsertLast_NotEmptyList_ElementAddedAtLastPosOfList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast("first");
            list.InsertLast("second");
            var node = list.GetNode("second");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("second", node.data);
            Assert.AreEqual(node.next, null);
        }


        [Test]
        public void IsertLast_EmptyList_OnlyThisElementInList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            var node = list.GetNode("first");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            Assert.AreEqual("first", node.data);
            Assert.AreEqual(node.next, null);
        }

        [Test]
        public void IsertAt_NotEmptyList_ElementAddedAtLastPosOfList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast("first");
            list.InsertLast("second");
            list.InsertAt("middle", 1);
            var node = list.GetNode("middle");
            // muss ersten node sein -> next.data == "first"
            Assert.IsNotNull(node);
            // next node should be "second"
            Assert.AreEqual("middle", node.data);
            Assert.AreNotEqual(node.next, null);
            Assert.AreEqual(node.next.data, "second");
        }


        [Test]
        public void DeleteNode_EmptyList_DoesNotCrash()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.DeleteNode(1);
        }

        [Test]
        public void DeleteNode_NoEmptyList_DeleteElement()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertLast("first");
            list.InsertLast("second");
            list.DeleteNode(1);
        }

        [Test]
        public void GetNode_EmptyList_ReturnsNull()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            var node = list.GetNode("first");
            // throws Exectpoin -> bitte korrigieren
        }

        [Test]
        public void GetNode_NodeExists_ReturnsNode()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst("first");
            list.InsertFirst("second");
            var node = list.GetNode("first");
            Assert.AreEqual("first", node.data);

        }
    }
}