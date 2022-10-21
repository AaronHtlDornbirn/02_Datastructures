using NUnit.Framework;
using SingleLinkedList;

namespace SingleLinkedListTest
{

    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void SwitchNodes_values_switched()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);
            
            var node1 = list.GetNode(2);
            var node2 = list.GetNode(3);           
            list.SwitchNodes(node1, node2);

            Assert.AreEqual(2, node2.Data);
            Assert.AreEqual(3, node1.Data);
        }

        [Test]
        public void SwitchNodes_firstNodeDoesNotExist()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);
            
            var node1 = list.GetNode(2);
            var node2 = list.GetNode(3);
            node1 = null;

            Assert.AreEqual(null, list.SwitchNodes(node1, node2));
        }

        [Test]
        public void SwitchNodes_secondNodeDoesNotExist()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);

            var node1 = list.GetNode(2);
            var node2 = list.GetNode(3);
            node2 = null;

            Assert.AreEqual(null, list.SwitchNodes(node1, node2));
        }
    }
}