using NUnit.Framework;
using SingleLinkedList;

namespace SingleLinkedListTest
{
    public class Tests
    {
        [SetUp]
        public void Setup() {}

        [Test]
        public void TestLinkedList_AddItems_ReturnsCorrectList()
        {
            SingleLinkedList.SingleLinkedList list = new SingleLinkedList.SingleLinkedList();
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            Assert.AreEqual(list.Last(), 1);
        }
    }
}