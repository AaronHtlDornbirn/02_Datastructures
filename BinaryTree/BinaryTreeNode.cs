using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeNode
    {
        public int Data;
        public BinaryTreeNode LeftChild;
        public BinaryTreeNode RightChild;

        public BinaryTreeNode(int data)
        {
            Data = data;
            LeftChild = null;
            RightChild = null;
        }

        internal bool IsLeaf()
        {
            throw new NotImplementedException();
        }
    }
}