using NUnit.Framework;
using Stack;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup() {}

        [Test]
        public void TestStack()
        {
            CustomStack<int> stack = new CustomStack<int>();
            Assert.AreEqual(stack.size(), 0);
            stack.Push(1);
            Assert.AreEqual(stack.size(), 1);
            Assert.Pass();
        }

        [Test]
        public void TestLinkedList()
        {
            SingleLinkedList.SingleLinkedList linkedlist= new SingleLinkedList.SingleLinkedList();
            linkedlist.InsertFirst(1);
            linkedlist.InsertFirst(2);
            linkedlist.InsertFirst(3);
            Assert.AreEqual(linkedlist.Last(), 1);
        }
    }
}