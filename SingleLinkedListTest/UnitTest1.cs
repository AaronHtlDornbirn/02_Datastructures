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
            list.InsertFirst("first");
            list.InsertLast("last");
            list.InsertAfter("mitte",2);
            Assert.AreEqual(list.Count(), 4);
            list.DeleteNode(2);
            Assert.AreEqual(list.Count(), 3);
        }
    }
}