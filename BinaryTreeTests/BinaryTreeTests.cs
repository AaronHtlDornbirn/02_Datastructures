using NUnit.Framework;

namespace BinaryTreeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinaryTree_InsertElement_ElementAtRightPlace()
        {
            BinaryTree.BinaryTree tree = new BinaryTree.BinaryTree();
            tree.InsertElement(5);
            tree.InsertElement(8);
            tree.InsertElement(3);
            tree.InsertElement(2);
            tree.InsertElement(7);
            tree.InsertElement(9);
            tree.InsertElement(1);
            Assert.AreEqual(5, tree.Root.Data);
            Assert.AreEqual(8, tree.Root.RightChild.Data);
            Assert.AreEqual(3, tree.Root.LeftChild.Data);
            Assert.AreEqual(2, tree.Root.LeftChild.LeftChild.Data);
            Assert.AreEqual(7, tree.Root.RightChild.LeftChild.Data);
            Assert.AreEqual(9, tree.Root.RightChild.RightChild.Data);
            Assert.AreEqual(1, tree.Root.LeftChild.LeftChild.LeftChild.Data);
        }
    }
}