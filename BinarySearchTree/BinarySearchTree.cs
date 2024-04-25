namespace BinarySearchTrees
{


    class BinarySearchTree
    {
        public class Node
        {
            public Node left;
            public Node right;
            public int value;
            public int hight;
        }

        public Node root;


        public BinarySearchTree()
        {
            if (root == null)
            {
                if (root == null)
                {
                    root = new Node()
                    {
                        value = 0,
                        hight = 0,
                    };
                }
            }
        }

        public BinarySearchTree(int rootValue)
        {
            if (root == null)
            {
                root = new Node()
                {
                    value = rootValue,
                    hight = 0,
                };
            }
        }

        public void insert(Node node)
        {
            insert(root, node);
        }

        private void insert(Node PNode, Node CNode)
        {
            if (CNode.value <= PNode.value)
            {
                if (PNode.left != null)
                {
                    insert(PNode.left, CNode);
                }
                else
                {
                    PNode.left = CNode;
                }
            }

            else
            {
                if (PNode.right != null)
                {
                    insert(PNode.right, CNode);
                }
                else
                {
                    PNode.right = CNode;
                }
            }
        }
    }
}
