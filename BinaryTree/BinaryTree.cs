namespace BinaryTree
{
    public class BinaryTree
    {
        public BinaryTreeNode Root;

        public override string ToString()
        {
            return getElementsAsString(Root);
        }
        string getElementsAsString(BinaryTreeNode element)
        {
            if (element == null)
                return "";
            if (element.IsLeaf())
                return element.ToString();
            return getElementsAsString(element.LeftChild)
                + element.ToString()
                + getElementsAsString(element.RightChild);
        }

        public void InsertElement(int Data)
        {
            BinaryTreeNode current = Root;

            if (Root == null)
            {
                Root = new BinaryTreeNode(Data);
            }
            else
            {
                while (true)
                {
                    if (current != null && current.Data == Data)
                    {
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        if (Data < current.Data)
                        {
                            if (current.LeftChild == null)
                            {
                                current.LeftChild = new BinaryTreeNode(Data);
                                return;
                            }
                            current = current.LeftChild;
                        }
                        else
                        {
                            if (current.RightChild == null)
                            {
                                current.RightChild = new BinaryTreeNode(Data);
                                return;
                            }
                            current = current.RightChild;
                        }
                    }
                }
            }
        }   
    }
}
